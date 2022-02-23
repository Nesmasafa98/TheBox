using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{


    public class User
    {

        static public List<User> players = new List<User>();


        public static Room CurrentRoom;
        private string username;
     //   public ClientSocket socket1;
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

        public static void sendAvaibleUsers(BinaryWriter streamWriter)
        {
            foreach (var i in players)
            {
                string strJson = JsonConvert.SerializeObject(i);
                streamWriter.Write(strJson);

            }

        }
        public static void SendPlayer(User player, BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(player);

            binaryWriter.Write(strJson);
        }


        public static User Receiver(BinaryReader br)
        {

            return JsonConvert.DeserializeObject<User>(br.ReadString());

        }
    }
}
