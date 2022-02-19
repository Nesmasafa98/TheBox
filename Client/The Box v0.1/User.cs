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
    //    public ClientSocket socket;
        private Room room;

        private string color;

        public string UserName
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }

        public string Username { get => username; set => username = value; }
        public Room Room { get => room; set => room = value; }
        public string Color { get => color; set => color = value; }

        public User(string name)
        {
            UserName = name;
       //     this.socket = socket;
        }

        public static void SendPlayer(User player, BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(player);

            binaryWriter.Write(strJson);
        }


        public static User Receiver(string s)
        {

            return JsonConvert.DeserializeObject<User>(s);

        }
    }
}

