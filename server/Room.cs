using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Connect_4
{
    public class Room
    {
        public string id;
        public User Player1;
        public User Player2;
        public User[] Watchers;
        public Board board;
        public bool StartGame = false;
        public Game game;
        static  public List<Room> avaibleRoom = new List<Room>();
        public Room(User owner, string Id, string size)
        {
            Player1 = owner;
            this.id = Id;
            board = new Board(size);
        }

        public void PlayBtn(User player)
        {
            Player2 = player;
            StartGame = true;
            game = new Game();
        }

        public static void sendAvaibleRooms(BinaryWriter streamWriter)
        {
            foreach (var i in avaibleRoom)
            {
                string strJson = JsonConvert.SerializeObject(i);
                streamWriter.Write(strJson);

            }

        }


        public static int FindindexOfRoom(String Id)
        {

            int i = 0;

            for (; i < avaibleRoom.Count; i++)
            {
                if (avaibleRoom[i].id == Id)

                {
                   // Console.WriteLine("i find it ");

                    break;

                }
            }
            return i;
        }
        public static void  addSecoondPlayTORoom(String roomId, BinaryWriter streamWriter,User player2)
        {

            int i = 0;
            for (; i < avaibleRoom.Count; i++)
            {
                if (avaibleRoom[i].id == roomId)

                {
                    avaibleRoom[i].PlayBtn(player2);


                    string strJson = JsonConvert.SerializeObject(avaibleRoom[i]);
                    streamWriter.Write(strJson);
                    break;
                }
            }

        }


    }
}
