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

        private string username;

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

        public string Username { get => Username1; set => Username1 = value; }
        public Room Room { get => Room1; set => Room1 = value; }
        public string Color { get => Color1; set => Color1 = value; }
        public string Username1 { get => username; set => username = value; }
        public Room Room1 { get => room; set => room = value; }
        public string Color1 { get => color; set => color = value; }

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
