using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Box_v0._1;
using static The_Box_v0._1.Game;

//using Newtonsoft.Json;

namespace The_Box_v0._1 
{
    public interface ClientSocketInterface
    {
        void SendRequest(string s);
        Room Responseplay(string id);
        Boolean ResponsecheckIfisInList(string UserName);
        void StateConfigPlayer1();
        void StateConfigPlayer2();
        state[,] ResponseReceiveState();
        Room ResponseJoin(User Myuser, string id, string p2Color);
        Room ResponseWatch(string id);
        void ResponseLog(User user);
        void ResponseShowplayer(List<User> players);
        void ResponseShowRooms(List<Room> rooms);
        Room ResponseCreate(User player1, string id, int index, string p1color);

    }
    public  class ClientSocket : ClientSocketInterface
    {
        public   static NetworkStream networkStream;
        static int port = 5002;
        public static BinaryWriter streamWriter;
        public static BinaryReader streamReader;

        static public  TcpClient ny;


        private static readonly object locker = new object();

        private static ClientSocket instance = null;
        public static ClientSocket SingletonClient()
        {


            lock (locker)
            {
                if (instance == null)
                {
                    instance = new ClientSocket();
                }
                return instance;
            }

        }
        private  ClientSocket()
        {
            ny = new TcpClient();


            ny.Connect(IPAddress.Parse("127.0.0.1"), ClientSocket.port);

            networkStream = ny.GetStream();

            streamWriter =
                 new BinaryWriter(networkStream);
            streamReader =
                 new BinaryReader(networkStream);
        }

        public static void CheckThereAreSameNameOrNot(string s)
        {   // send request which you want form the server 
            streamWriter.Write(s);
        }

        void ClientSocketInterface.SendRequest(string s)
        {   // send request which you want form the server 
            streamWriter.Write(s);
        }
        //  Responoe player one  when clicking on play bn
        Room ClientSocketInterface.Responseplay(string id)
        {
            String s = streamReader.ReadString();
            if (s == "play")
            {
                streamWriter.Write(id);

                streamReader.ReadString();
                string message = "Do you want to close this window?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    streamWriter.Write("yes");
                    return Room.DeepReceive(streamReader);
                }
                else
                {
                    streamWriter.Write("no");
                    return null;
                }
                
            }
            return null;


        }


        Boolean ClientSocketInterface.ResponsecheckIfisInList(string UserName)
        {
            String s = streamReader.ReadString();
            if (s == "IfisInList")
            {
                streamWriter.Write(UserName);
              return  streamReader.ReadBoolean();
            }
            return false;


        }

        void ClientSocketInterface.StateConfigPlayer1()
        {   // sync with server that it will go in player 1 loop
            String s = streamReader.ReadString();
            streamWriter.Write(User.CurrentRoom.Id);

        }


        void ClientSocketInterface.StateConfigPlayer2()
        {// sync with server that it will go in player 2 loop

            String s = streamReader.ReadString();
            streamWriter.Write(User.CurrentRoom.Id);


        }
        state[,] ClientSocketInterface.ResponseReceiveState()
        { // received state from server
            String s = streamReader.ReadString();
            if (s == "ReceiveState")
            {

                return Game.ReceiveState(streamReader);
            }
            return null;
        }
        Room ClientSocketInterface.ResponseJoin(User Myuser, string id, string p2Color)
        {       //receive room when player to request join in loop
            String s = streamReader.ReadString();
            if (s == "join")
            {
                Console.WriteLine("Start Join");

                Console.WriteLine("AnaBreceive");
                Myuser.SendPlayer(streamWriter);

                Console.WriteLine("Enter Id of Room");
                //    String Idroom = Console.ReadLine();
                streamWriter.Write(id);
                streamWriter.Write(p2Color);
                string x = streamReader.ReadString();
                Console.WriteLine("Receive oop");

                if (x == "yes")
                    return Room.ReceiveRoom(streamReader);
                else
                    return null;
                //   Console.WriteLine("I receive room!");
            }
            return null;
        }


        Room ClientSocketInterface.ResponseWatch(string id)
        {       //receive room when player to request join in loop
            String s = streamReader.ReadString();
            if (s == "Watch")
            {

                streamWriter.Write(id);

                return Room.ReceiveRoom(streamReader);
                //   Console.WriteLine("I receive room!");
            }
            return null;
        }
        void ClientSocketInterface.ResponseLog(User user)
        {
                //log in Game
            String s = streamReader.ReadString();

            if (s == "log")
            {
                user.SendPlayer(streamWriter);




            }
        }

        void ClientSocketInterface.ResponseShowplayer(List<User> players)
        {
            // receiving list of (active) players from server
            String s = streamReader.ReadString();
            if (s == "showplayer")
            {

                Console.WriteLine(streamReader.ReadString());
                s = streamReader.ReadString();


                while (s != "end")
                {




                    User receivedpayer = User.Receiver(s);

                    players.Add(receivedpayer);
                    Console.WriteLine("I receive room!");
                    s = streamReader.ReadString();


                }

            }
        }

        void ClientSocketInterface.ResponseShowRooms(List<Room> rooms)
        {       //receiving avaible rooms from serveer
            String s = streamReader.ReadString();
            if (s == "showRooms")
            {


                Console.WriteLine(streamReader.ReadString());
                s = streamReader.ReadString();
                ;
                while (s != "end")
                {


                    Room receivedRoom = Room.ReceiveRoom(s);

                    rooms.Add(receivedRoom);
                    Console.WriteLine("I receive room!");
                    s = streamReader.ReadString();


                }


            }


        }

        Room ClientSocketInterface.ResponseCreate(User player1, string id, int index, string p1color)
        {   // receiving owner and id and size of board you want
            // index will reflect with size specific in Room 
            String s = streamReader.ReadString();
            // receive Create request from protocol
            if (s == "create")
            {
                player1.SendPlayer(streamWriter);

                streamWriter.Write(id);

                streamWriter.Write(index.ToString());
                streamWriter.Write(p1color);


                return Room.ReceiveRoom(streamReader);


                // Myuser.room = room;
            }
            // return received room which created from user
            return Room.ReceiveRoom(streamReader);
        }


    }

}
//            public static void CheckRespornse(User Myuser,List<Room> rooms,List<User> players,Room CreatedRoom)
//        {





//            {

//                Console.WriteLine("Enter New Command:");

//                String s = streamReader.ReadString();

//                if (s == "log")
//                {
//                    MessageBox.Show("ana Da5lt ellog ");
//                    User.SendPlayer(Myuser,streamWriter);


                    

//                }

//                     if (s=="showplayer")
//                {
//                    MessageBox.Show("ana Da5lt players ");
//                  //  Console.WriteLine("ana Da5lt join ");

//                    Console.WriteLine(streamReader.ReadString());
//                    s = streamReader.ReadString();
//                    //  MessageBox.Show("ana 3mlt recevie");
//                    // Room ag = new Room(Myuser, "ahmed", "fsadf");
                   
//                    while (s != "end")
//                    {




//                        User receivedpayer = User.Receiver(s);

//                        players.Add(receivedpayer);
//                        Console.WriteLine("I receive room!");
//                        s = streamReader.ReadString();


//                    }

//                    Console.WriteLine("Yes i Do it ");
//                }
//                Console.WriteLine("reecive " + s);
//                    if (s == "showRooms")
//                {
//                    MessageBox.Show("ana Da5lt rooms ");

//                    Console.WriteLine("ana Da5lt join ");
                  
//                    Console.WriteLine(streamReader.ReadString());
//                        s = streamReader.ReadString();
//                  //  MessageBox.Show("ana 3mlt recevie");
//                //    Room ag = new Room(Myuser, "ahmed", 5);
//                 //   rooms.Add(ag);
//                    while (s != "end")
//                        {


//                            Room receivedRoom = Room.ReceiveRoom(s);

//                        rooms.Add(receivedRoom);
//                        Console.WriteLine("I receive room!");
//                            s = streamReader.ReadString();


//                        }

//                        Console.WriteLine("Yes i Do it ");
//                    }
//                    if (s == "create")
//                    {
//                        Console.WriteLine("AnaBreceive");
//                        User.SendPlayer(CreatedRoom.Player1, streamWriter);

//                        Console.WriteLine("Enter Id of Room");
//                        //String Idroom = Console.ReadLine();
//                        streamWriter.Write(CreatedRoom.id);
//                        Console.WriteLine("Enter Size Of room");
//                        //String size = Console.ReadLine();
//                        streamWriter.Write(CreatedRoom.index.ToString());
                      
//                        Room room = Room.ReceiveRoom(streamReader);
//                        Console.WriteLine("I receive room!");

                        
//                        Myuser.room = room;



//                    /*
                     
//                    ********* un commentny yastaaaaaaaaaaaaa*******************

//                        Console.WriteLine("player1 playing");
//                        Game.SendGame(Myuser.room.game, streamWriter);
//                       // streamWriter.Write("player one played");
//                        while (true)
//                        {
//                            // Console.WriteLine(streamReader.ReadString());

//                            Console.WriteLine("Recived player2 playing");

//                            Myuser.room.game= Game.Receiver(streamReader);
//                            Console.WriteLine("send  player2 playing");
//                            //streamWriter.Write("player one played");
//                            Game.SendGame(Myuser.room.game, streamWriter);
                           
//                        }

//                    */

//                    }

//                    if (s == "join")
//                    {
//                        Console.WriteLine("Start Join");

//                        Console.WriteLine("AnaBreceive");
//                        User.SendPlayer(Myuser, streamWriter);

//                        Console.WriteLine("Enter Id of Room");
//                        String Idroom = Console.ReadLine();
//                        streamWriter.Write(Idroom);

//                        Room   room = Room.ReceiveRoom(streamReader);
//                        Console.WriteLine("I receive room!");
//                    Myuser.room = room;

//                       Console.WriteLine("ana gamed");

//                        Console.WriteLine("End Join");

//                        while (true)
//                        {
//                            //Console.WriteLine(streamReader.ReadString());
//                            //streamWriter.Write("player 2 played");
//                            Console.WriteLine("Recived player1 playing");

//                            Myuser.room.game = Game.Receiver(streamReader);
//                            Console.WriteLine("send  player2 playing");
//                            //streamWriter.Write("player one played");
//                            Game.SendGame(Myuser.room.game, streamWriter);
//                            Console.WriteLine("done Saving");
//                        }

  

//                    }




//                    s = "";
//                }
           
      
//            //return 0;

//        }
//    }
//}
