using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4___Client
{
    class Program
    {
        static int flag = 0;
        static int[] port;
        static int counter = 0;
        static void Main(string[] args)
        {
            ClientSocket myclient = new ClientSocket(4000);
            User user = new User("Ahed");
            while (true)
            {
                ClientSocket.SendRequest(Console.ReadLine());
                ClientSocket.CheckRespornse(user);


            }
        }

    }
}
