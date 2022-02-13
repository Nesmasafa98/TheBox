using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect_4
{
    class GameServer
    {
        TcpListener server;
        public GameServer(int PortNum, int numOFClient)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), PortNum);
            // server2 = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);

            server.Start();
            // server2.Start();

            Console.WriteLine("************This is Server program5000************");

            Console.WriteLine("************This is Server program5000************");
            Console.WriteLine("Hoe many clients are going to connect to this server?:");
            int numberOfClientsYouNeedToConnect = numOFClient;
            for (int i = 0; i < numberOfClientsYouNeedToConnect; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }
        }

        private void Listeners()
        {
            Socket socketForClient = server.AcceptSocket();



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
                    Console.WriteLine("value of Received is// :" + theString);
                    //     streamWriter.Flush();
                    if (theString == "1")
                    {


                        streamWriter.Write("room");
                        SendServerInfo(streamWriter);
                    }

                    if (theString == "2")
                    {
                        streamWriter.Write("create");

                        for (int i = 0; i < 5; i++)
                        {
                            streamWriter.Write(i);
                        }

                    }
                }

                Console.WriteLine("Message recieved by client:" + theString);
                if (theString == "exit")
                    break;

            }
            streamReader.Close();
            networkStream.Close();
            streamWriter.Close();



            socketForClient.Close();
            Console.WriteLine("Press any key to exit from server program");
            Console.ReadKey();
        }


        public void SendServerInfo(BinaryWriter BR)
        {
            {
                int server = 4;
                BR.Write("i will receive ");
                BR.Write(server);
            }



        }
    }
}
