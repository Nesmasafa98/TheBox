using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Box_v0._1
{
    public class User
    {
        public static Room CurrentRoom;
        private string username;
        public  ClientSocket socket1;
        private Room room;

        private string color;



        public string Username { get => username; set => username = value; }
        public Room Room { get => room; set => room = value; }
        public string Color { get => color; set => color = value; }

        public User(string name)
        {
            username = name;
            //     this.socket = socket;
           
        }

        public  void SendPlayer(BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(this);

            binaryWriter.Write(strJson);
        }



        public  static User Receiver(string s)
        {

            return JsonConvert.DeserializeObject<User>(s);

        }
    }
}

