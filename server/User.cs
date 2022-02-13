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

        public string username;
        public int Score;
        public bool IsRoomOwner;
        public bool IsPlayer;

        //        public ClientSocket socketconfig;
        public Room room;
        static public List<User> players = new List<User>();

        public string color;



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

        //  public ClientSocket Socketconfig { get => socketconfig; set => socketconfig = value; }

        public User(string name)
        {
            UserName = name;
            // socketconfig = new ClientSocket(4000);
            // this.score = 0;
            //this.isplayer = false;
            //this.isroomowner = false;
            //room = null;


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
