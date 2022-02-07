using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Client
{



   public class ClientSocket
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



        public static  void CheckRespornse(User Myuser )
        {
            try
            {



                {

                    Console.WriteLine("type:");

                    String s = streamReader.ReadString();


                    Console.WriteLine("reecive " + s);
                    if (s == "join")
                    {
                        Console.WriteLine("ana Da5lt join ");
                        Console.WriteLine (streamReader.ReadString());
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
                        streamWriter.Write("ahmed");
                        streamWriter.Write("ahmed");

                        Console.WriteLine("ana gamed");

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