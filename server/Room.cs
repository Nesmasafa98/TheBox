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
        public int _row;
        public int _col;
        public string player1Color="red";
        public string player2Color = "green";



        public int index;

        public Room(User owner, string Id, int index)
        {
            Player1 = owner;
            this.id = Id;
            //board = new Board(size);
            this.index = index;
           // Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee" + index);
            DetrimineSize(index);
        }

        public void PlayBtn(User player)
        {
            Player2 = player;
            game = new Game(_row, _col, Player1, Player2);

            StartGame = true;
        }
        public void DetrimineSize(int index)
        {
            switch (index)
            {
                case 1:
                    _row = 7;
                    _col = 8;

                    break;
                case 2:
                    _row = 7;
                    _col = 9;
                    break;
                case 3:
                    _row = 7;
                    _col = 10;
                    break;
                default:
                    _row = 6;
                    _col = 7;
                    break;
            }
        }

        public static void sendAvaibleRooms(BinaryWriter streamWriter)
        {
            foreach (var i in avaibleRoom)
            {
                string strJson = JsonConvert.SerializeObject(i);
                streamWriter.Write(strJson);

            }

        }
        public static void DeepSend(Room room, BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(room);

            binaryWriter.Write(strJson);
            binaryWriter.Write(JsonConvert.SerializeObject(room.Player1));
            binaryWriter.Write(JsonConvert.SerializeObject(room.Player2));

        }

        public static Room DeepReceive(BinaryReader receiver)
        {
            Room received = JsonConvert.DeserializeObject<Room>(receiver.ReadString());
            received.Player1 = JsonConvert.DeserializeObject<User>(receiver.ReadString());
            received.Player2 = JsonConvert.DeserializeObject<User>(receiver.ReadString());

            return received;
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

        public static void SendRoom(Room room, BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(room);

            binaryWriter.Write(strJson);
        }


        public static Room Receiver(BinaryReader br)
        {

            return JsonConvert.DeserializeObject<Room>(br.ReadString());

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
