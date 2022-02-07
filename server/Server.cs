using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections;

namespace Connect_4
{
    class Server
    {
        TcpListener server;
        List<Room> avaibleRoom = new List<Room>();
        ArrayList players = new ArrayList();



        public Server(int PortNum, int numOFClient)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), PortNum);
            // server2 = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);

            server.Start();
            // server2.Start();
            avaibleRoom.Add(new Room(new User("ahmed"), "ahmed", "tarek"));
            Console.WriteLine("************This is Server ************");

            Console.WriteLine("************This is Server program************" + PortNum);
            Console.WriteLine("Hoe many clients are going to connect to this server?:");
            int numberOfClientsYouNeedToConnect = numOFClient;
            for (int i = 0; i < numberOfClientsYouNeedToConnect; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
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
                        Console.WriteLine("helooooo");
                        if (theString == "log")
                        {


                            streamWriter.Write("log");

                            streamWriter.Write("start");
                            foreach (var i in avaibleRoom)
                            {
                                string strJson = JsonConvert.SerializeObject(i);
                                streamWriter.Write(strJson);

                            }
                            streamWriter.Write("end");



                            //    SendServerInfo(streamWriter,streamReader);
                            Thread.Sleep(10);
                            //      new Server(9000, 6);


                        }

                        if (theString == "create")

                        {
                            Console.WriteLine("Start Create");

                            streamWriter.Write("create");


                            User player1 = JsonConvert.DeserializeObject<User>(streamReader.ReadString());
                            string id = streamReader.ReadString();
                            avaibleRoom.Add(new Room(player1, id, streamReader.ReadString()));
                            Console.Write(" i create a room ");

                            int i = 0;

                            for (; i < avaibleRoom.Count; i++)
                            {
                                if (avaibleRoom[i].id == id)

                                {
                                    Console.WriteLine("i find it ");

                                    break;

                                }
                            }

                            while (avaibleRoom[i].StartGame == false) ;



                            string strJson = JsonConvert.SerializeObject(avaibleRoom[i]);
                            streamWriter.Write(strJson);
                            Console.WriteLine(" End Create ");




                        }



                        if (theString == "join")
                        {
                            streamWriter.Write("join");
                            Console.WriteLine("Start Join");

                            Console.WriteLine("AnaBreceive");
                            User player2 = JsonConvert.DeserializeObject<User>(streamReader.ReadString());
                            string roomId = streamReader.ReadString();

                            int i = 0;
                            for (; i < avaibleRoom.Count; i++)
                            {
                                if (avaibleRoom[i].id == roomId)

                                {
                                    avaibleRoom[i].PlayBtn(player2);


                                    string strJson = JsonConvert.SerializeObject(avaibleRoom[i]);
                                    streamWriter.Write(strJson);
                                    break;
                                }
                            }
                            Console.WriteLine("ok I did it ");
                            Console.WriteLine("Start Join");

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


        public void SendServerInfo(BinaryWriter BR, BinaryReader BRR)
        {
            {
                string strJson = JsonConvert.SerializeObject(new ABC());
                int server = 4;
                BR.Write(strJson);
                BR.Write(server);
                strJson = BRR.ReadString();
                Console.WriteLine(strJson);

                User deptObj = JsonConvert.DeserializeObject<User>(strJson);
                Console.WriteLine("Name Id: {0}", deptObj.username);

            }

        }
    }
}
