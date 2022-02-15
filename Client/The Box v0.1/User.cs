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
        public string username;
        public int Score;
        public bool IsRoomOwner;
        public static Room CurrentRoom;
        public bool IsPlayer;
        public string color;

        //        public ClientSocket socketconfig;
        public Room room;
        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public User(string name)
        {
            UserName = name;
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

