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

namespace Connect_4___Client
{
    class ClientSocket
    {
        static NetworkStream networkStream;
        static TcpClient Socket;
        static int port;
        static BinaryWriter streamWriter;
        static BinaryReader streamReader;
        public ClientSocket(int port)
        {
            ClientSocket.port = port;
            Socket = new TcpClient();

            Console.WriteLine("hello");
            Socket.Connect(IPAddress.Parse("127.0.0.1"), ClientSocket.port);

            networkStream = Socket.GetStream();

            streamWriter =
     new BinaryWriter(networkStream);
            streamReader =
                 new BinaryReader(networkStream);
        }

        public static void SendRequest(string s)
        {
            streamWriter.Write(s);
        }



        public static void CheckRespornse(User Myuser)
        {
            try
            {



                {

                    Console.WriteLine("Enter New Command:");

                    String s = streamReader.ReadString();


                    Console.WriteLine("reecive " + s);
                    if (s == "log")
                    {
                        Console.WriteLine("ana Da5lt join ");
                        Console.WriteLine(streamReader.ReadString());
                        s = streamReader.ReadString();
                        while (s != "end")
                        {


                            Room deptObj = JsonConvert.DeserializeObject<Room>(s);
                            Console.WriteLine("I receive room!");
                            s = streamReader.ReadString();


                        }

                        Console.WriteLine("Yes i Do it ");
                    }
                    if (s == "create")
                    {
                        Console.WriteLine("AnaBreceive");
                        string strJson = JsonConvert.SerializeObject(Myuser);

                        streamWriter.Write(strJson);
                        Console.WriteLine("Enter Id of Room");
                        String Idroom = Console.ReadLine();
                        streamWriter.Write(Idroom);
                        Console.WriteLine("Enter Size Of room");
                        String size = Console.ReadLine();
                        streamWriter.Write(size);
                        Room room = JsonConvert.DeserializeObject<Room>(streamReader.ReadString());
                        Console.WriteLine("I receive room!");


                        Myuser.room = room;

                        Console.WriteLine(" do it bedad");


                        Console.WriteLine("ana gamed");

                    }

                    if (s == "join")
                    {
                        Console.WriteLine("Start Join");

                        Console.WriteLine("AnaBreceive");
                        string strJson = JsonConvert.SerializeObject(Myuser);

                        streamWriter.Write(strJson);
                        Console.WriteLine("Enter Id of Room");
                        String Idroom = Console.ReadLine();
                        streamWriter.Write(Idroom);

                        Room deptObj = JsonConvert.DeserializeObject<Room>(streamReader.ReadString());
                        Console.WriteLine("I receive room!");


                        Console.WriteLine("ana gamed");

                        Console.WriteLine("End Join");


                    }



                    s = "";
                }
            }
            catch
            {
                Console.WriteLine("Exception reading from Server");
            }
            //return 0;

        }
    }
}
