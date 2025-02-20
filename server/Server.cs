﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Collections;
using static Connect_4.Game;
using System.Windows.Forms;

namespace Connect_4
{
    interface ServerInterface
    {
        void requestLog(BinaryWriter streamWriter, BinaryReader streamReader);
        void checkInList(BinaryWriter streamWriter, BinaryReader streamReader);
        void requestPlayers(BinaryWriter streamWriter, BinaryReader streamReader);
        void requestWatch(BinaryWriter streamWriter, BinaryReader streamReader);
        void configPlayer1(BinaryWriter streamWriter, BinaryReader streamReader);
        void configPlayer2(BinaryWriter streamWriter, BinaryReader streamReader);
        void requestRooms(BinaryWriter streamWriter, BinaryReader streamReader);
        void requestPlay(BinaryWriter streamWriter, BinaryReader streamReader);
        void requestCreate(BinaryWriter streamWriter, BinaryReader streamReader);
        void requestJoin(BinaryWriter streamWriter, BinaryReader streamReader);

    }
    class Server : ServerInterface
    {
        TcpListener server;
        //List<Room> avaibleRoom = new List<Room>();
        ArrayList players = new ArrayList();
        // static Game laststate;

        int port;
        static int row;
        static int col;
        static Boolean flag = false;
        static Game temp;
        bool isWinner = false;

        private Server(int PortNum, int numOFClient)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), PortNum);
            // server2 = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);

            server.Start();
            // server2.Start();
            //avaibleRoom.Add(new Room(new User("ahmed"), "ahmed", "tarek"));
           

            Console.WriteLine("************This is  program************" + PortNum);
           
            int numberOfClientsYouNeedToConnect = numOFClient;
            for (int i = 0; i < numberOfClientsYouNeedToConnect; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }

        }

        private static readonly object locker = new object();

        private static Server instance = null;
        public static Server SingletonServer( int port , int  numofClients)
        {
            
           
                lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Server(port, numofClients);
                        }
                        return instance;
                    }
            
        }
    

    void Listeners()
        {

            Socket socketForClient = server.AcceptSocket();


            if (socketForClient.Connected)
            {
                bool connected = true;
                Console.WriteLine("Client:" + socketForClient.RemoteEndPoint + " now connected to server.");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                System.IO.BinaryWriter streamWriter =
                new System.IO.BinaryWriter(networkStream);
                System.IO.BinaryReader streamReader =
                new System.IO.BinaryReader(networkStream);


                //here we recieve client's text if any.
                while (connected)
                {
                    string theString;

                    try
                    {
                        theString = streamReader.ReadString();
                        Console.WriteLine("value of Received is :" + theString);
                        streamWriter.Flush();
                        

                        if (theString == "log")
                        {
                            ((ServerInterface)this).requestLog(streamWriter, streamReader);
                        }

                        if (theString == "IfisInList")
                        {
                            ((ServerInterface)this).checkInList(streamWriter, streamReader);
                        }

                        if (theString == "showplayer")
                        {
                            ((ServerInterface)this).requestPlayers(streamWriter, streamReader);
                        }

                        if (theString == "Watch")

                        {
                            ((ServerInterface)this).requestWatch(streamWriter, streamReader);
                        }

                        if (theString == "ConfigPlayer1")
                        {
                            ((ServerInterface)this).configPlayer1(streamWriter, streamReader);
                        }

                        if (theString == "ConfigPlayer2")
                        {
                            ((ServerInterface)this).configPlayer2(streamWriter, streamReader);
                        }

                        if (theString == "showRooms")
                        {
                            ((ServerInterface)this).requestRooms(streamWriter, streamReader);
                        }
                        if (theString == "play")
                        {
                            ((ServerInterface)this).requestPlay(streamWriter, streamReader);
                        }
                        if (theString == "create")

                        {
                            ((ServerInterface)this).requestCreate(streamWriter, streamReader);
                        }

                        if (theString == "join")
                        {
                            ((ServerInterface)this).requestJoin(streamWriter, streamReader);
                        }
                            
                        Console.WriteLine("Message recieved by client:" + theString);
                        if (theString == "exit")
                        {
                            connected = false;
                        }

                    }
                    catch (System.IO.IOException ex)
                    {
                        connected = false;
                    }

                }
                streamReader.Close();
                networkStream.Close();
                streamWriter.Close();

            }
            socketForClient.Close();
            Console.WriteLine("Press any key to exit from server program");
            Console.ReadKey();
        }

        void ServerInterface.requestLog(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("log");
            User.players.Add((User.Receiver(streamReader)));
        }

        void ServerInterface.checkInList(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            int flag = 0;
            streamWriter.Write("IfisInList");
            string UserName = streamReader.ReadString();
            for (int i = 0; i < User.players.Count; i++)

            {
                if (User.players[i].Username == UserName)
                {
                    Boolean x = true;
                    streamWriter.Write(x);
                    flag = 1;
                    break;

                }


            }
            if (flag == 0)
            {
                Boolean x = false;
                streamWriter.Write(x);
            }

        }

        void ServerInterface.requestPlayers(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("showplayer");

            streamWriter.Write("start");
            User.sendAvaibleUsers(streamWriter);
            streamWriter.Write("end");


            //    SendServerInfo(streamWriter,streamReader);
            Thread.Sleep(10);
            //      new Server(9000, 6);

        }

        void ServerInterface.requestWatch(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("Watch");
            string id = streamReader.ReadString();
            Room.SendRoom(Room.avaibleRoom[Room.FindindexOfRoom(id)], streamWriter);
        }

        void ServerInterface.configPlayer1(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("ConfigPlayer1");
            string id = streamReader.ReadString();
            Room roomState = Room.avaibleRoom[Room.FindindexOfRoom(id)];
            Console.WriteLine(roomState.Player1Color);
            roomState.Game = Game.Receiver(streamReader);
            Console.WriteLine("Change Turn");
            //streamReader.ReadString();
            roomState.Game.playerTurn();
            bool Iswinner = roomState.Game.Iswinner();
            while (!Iswinner)
            {

                while (roomState.Game.Player1 == false) ;
                Console.WriteLine("Send player 1");

                Game.SendGame(roomState.Game, streamWriter);
                Iswinner = roomState.Game.Iswinner();
                streamWriter.Write(Iswinner);

                if (Iswinner)
                {
                    Console.WriteLine("111111111111111111111111111111");
                    roomState.Game.playerTurn();

                    //        MessageBox.Show("Ana");


                    break;
                }
                Console.WriteLine("Send recive  1");

                roomState.Game = Game.Receiver(streamReader);

                roomState.Game.playerTurn();

            }

        }

        void ServerInterface.configPlayer2(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("ConfigPlayer2");

            string id = streamReader.ReadString();
            Room roomState = Room.avaibleRoom[Room.FindindexOfRoom(id)];
            bool Iswinner = roomState.Game.Iswinner();

            while (!Iswinner)
            {
                while (roomState.Game.Player2 == false) ;
                Console.WriteLine("Send  player 2");
                Game.SendGame(roomState.Game, streamWriter);
                Iswinner = roomState.Game.Iswinner();
                streamWriter.Write(Iswinner);

                if (Iswinner)
                {
                    Console.WriteLine("222222222222222222222222222222222");
                    roomState.Game.playerTurn();

                    break;
                }
                roomState.Game = Game.Receiver(streamReader);
                Console.WriteLine("reciving  player 2");

                roomState.Game.playerTurn();



            }

        }

        void ServerInterface.requestRooms(BinaryWriter streamWriter, BinaryReader streamReader)
        {

            streamWriter.Write("showRooms");

            streamWriter.Write("start");
            Room.sendAvaibleRooms(streamWriter);
            streamWriter.Write("end");

        }

        void ServerInterface.requestPlay(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("play");


            string id = streamReader.ReadString();

            while (Room.avaibleRoom[Room.FindindexOfRoom(id)].someOneEnter == false) ;


            streamWriter.Write("sendAplayer");
            //Room.SendRoom(Room.avaibleRoom[Room.FindindexOfRoom(id)], streamWriter);
            string x = streamReader.ReadString();
            if (x == "yes")
            {
                Room.avaibleRoom[Room.FindindexOfRoom(id)].play1Accecptance = 1;


                while (Room.avaibleRoom[Room.FindindexOfRoom(id)].StartGame1 == false) ;
                Room.avaibleRoom[Room.FindindexOfRoom(id)].RoomIsFull = true;

                row = Room.avaibleRoom[Room.FindindexOfRoom(id)].Game.Row;
                col = Room.avaibleRoom[Room.FindindexOfRoom(id)].Game.Col;
                temp = Room.avaibleRoom[Room.FindindexOfRoom(id)].Game;
                Room.DeepSend(Room.avaibleRoom[Room.FindindexOfRoom(id)], streamWriter);
                //   Room currentRoom = Room.avaibleRoom[Room.FindindexOfRoom(id)];
                Console.WriteLine("Send  player player1");
            }
            else
            {
                Console.WriteLine("dasssssssssssssssssss");
                Room.avaibleRoom[Room.FindindexOfRoom(id)].play1Accecptance = 2;

            }

        }

        void ServerInterface.requestCreate(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            Console.WriteLine("Start Create");

            streamWriter.Write("create");


            User player1 = JsonConvert.DeserializeObject<User>(streamReader.ReadString());
            string id = streamReader.ReadString();
            int index = int.Parse(streamReader.ReadString());
            string p1color = streamReader.ReadString();
            Room room = new Room(player1, id, index, p1color);
            Room.avaibleRoom.Add(room);


            //Console.Write(" i create a room ");
            //                            Console.Write(room.player1Color);

            //  Room.FindindexOfRoom(id);

            Room.SendRoom(Room.avaibleRoom[Room.FindindexOfRoom(id)], streamWriter);





            /*
             ****************lazem t3ml uncomment************
            while (Room.avaibleRoom[Room.FindindexOfRoom(id)].StartGame == false) ;

         //   Room currentRoom = Room.avaibleRoom[Room.FindindexOfRoom(id)];
            Console.WriteLine("Send  player player1");

            //  string strJson = JsonConvert.SerializeObject(Room.avaibleRoom[Room.FindindexOfRoom(id)]);
            Room.avaibleRoom[Room.FindindexOfRoom(id)].game = Game.Receiver(streamReader);
            Console.WriteLine("Change Turn");
            //streamReader.ReadString();
            Room.avaibleRoom[Room.FindindexOfRoom(id)].game.playerTurn();
            while(true)
            {

                while (Room.avaibleRoom[Room.FindindexOfRoom(id)].game.player1 == false) ;
                Console.WriteLine("Send player 1");

                Game.SendGame(Room.avaibleRoom[Room.FindindexOfRoom(id)].game, streamWriter);
                Console.WriteLine("Send recive  1");
                Room.avaibleRoom[Room.FindindexOfRoom(id)].game = Game.Receiver(streamReader);

                Room.avaibleRoom[Room.FindindexOfRoom(id)].game.playerTurn();


            }
                  ****************lazem t3ml uncomment************
            */

        }

        void ServerInterface.requestJoin(BinaryWriter streamWriter, BinaryReader streamReader)
        {
            streamWriter.Write("join");
            Console.WriteLine("Start Join");

            Console.WriteLine("AnaBreceive");
            User player2 = JsonConvert.DeserializeObject<User>(streamReader.ReadString());
            string roomId = streamReader.ReadString();
            string p2Color = streamReader.ReadString();

            Room.avaibleRoom[Room.FindindexOfRoom(roomId)].someOneEnter = true;

            while (Room.avaibleRoom[Room.FindindexOfRoom(roomId)].play1Accecptance == 0) ;



            if (Room.avaibleRoom[Room.FindindexOfRoom(roomId)].play1Accecptance == 1)
            {
                streamWriter.Write("yes");
                Room.addSecoondPlayTORoom(roomId, streamWriter, player2, p2Color);
            }
            else
            {

                Console.WriteLine("ana nennnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnna");
                streamWriter.Write("no");
                Room.avaibleRoom[Room.FindindexOfRoom(roomId)].play1Accecptance = 0;
                Room.avaibleRoom[Room.FindindexOfRoom(roomId)].someOneEnter = false;


            }



            Console.WriteLine("ok I did it ");
            Console.WriteLine("End Join");
            /*
          //  Room current=Room.avaibleRoom[Room.FindindexOfRoom(roomId)];
            while (true)
            {
                while (Room.avaibleRoom[Room.FindindexOfRoom(roomId)].game.player2 == false) ;
                Console.WriteLine("Send  player 2");
                Game.SendGame(Room.avaibleRoom[Room.FindindexOfRoom(roomId)].game, streamWriter);

                Room.avaibleRoom[Room.FindindexOfRoom(roomId)].game = Game.Receiver(streamReader);
                Console.WriteLine("reciving  player 2");
                Room.avaibleRoom[Room.FindindexOfRoom(roomId)].game.playerTurn();

            }
            */
        }


    }
}
