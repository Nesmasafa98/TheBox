using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections;

namespace ConnectFourServer
{

    class Server
    {
        TcpListener server;
        ArrayList avaibleRoom = new ArrayList();
        ArrayList players = new ArrayList();



        public Server(int PortNum, int numOFClient)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), PortNum);
            // server2 = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);

            server.Start();
            // server2.Start();
            avaibleRoom.Add(new Room(new User("ahmed"), "ahmed", "tarek"));
            Console.WriteLine("************This is Server ************");

            Console.WriteLine("************This is Server program************"+ PortNum);
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
                Console.WriteLine("Client:" + socketForClient.RemoteEndPoint + " now connected to server.");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                System.IO.BinaryWriter streamWriter =
                new System.IO.BinaryWriter(networkStream);
                System.IO.BinaryReader streamReader =
                new System.IO.BinaryReader(networkStream);


                //here we recieve client's text if any.
                while (true)
                {
                    string theString;
                    
                    {
                        theString = streamReader.ReadString();
                        Console.WriteLine("value of Received is :" + theString);
                        streamWriter.Flush();
                        Console.WriteLine("helooooo");
                        if (theString == "join")
                        {
                        

                            streamWriter.Write("join");
                            
                            streamWriter.Write("start");
                           foreach ( var i  in avaibleRoom )
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
                        //  {
                        {
                            streamWriter.Write("create");


                            User player1 = JsonConvert.DeserializeObject<User>(streamReader.ReadString());

                        avaibleRoom.Add(new Room(player1, streamReader.ReadString(), streamReader.ReadString()));
                            Console.Write("ohh i did it ");
                        }
                    }

                    Console.WriteLine("Message recieved by client:" + theString);
                    if (theString == "exit")
                        break;

                }
                streamReader.Close();
                networkStream.Close();
                streamWriter.Close();


            }
            socketForClient.Close();
            Console.WriteLine("Press any key to exit from server program");
            Console.ReadKey();
        }


        public void SendServerInfo(BinaryWriter BR,BinaryReader BRR )
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