using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public class Room
    {
        public static List<Room> rooms;
        public static List<Room> fullRooms = new List<Room>();
        private string id;
        private User player1;
        private User player2;
        //public Board board;
        private bool StartGame = false;
        private Game game;
        public int play1Accecptance = 0;
        public bool someOneEnter = false;

        private int _row;
        private int _col;
        private bool roomIsFull = false;
        private string player1Color = "red";
        private string player2Color = "green";

        public int index;

        public string Id { get => id; set => id = value; }
        public User Player1 { get => player1; set => player1 = value; }
        public User Player2 { get => player2; set => player2 = value; }
        public bool StartGame1 { get => StartGame; set => StartGame = value; }
        public Game Game { get => game; set => game = value; }
        public int Row { get => _row; set => _row = value; }
        public int Col { get => _col; set => _col = value; }
        public bool RoomIsFull { get => roomIsFull; set => roomIsFull = value; }
        public string Player1Color { get => player1Color; set => player1Color = value; }
        public string Player2Color { get => player2Color; set => player2Color = value; }

        public Room(User owner, string Id, int index)
        {
            Player1 = owner;


            //     Player1.color = "red";
            this.Id = Id;
            //board = new Board(size);
            this.index = index;
            DetrimineSize(index);
        }

        public void PlayBtn(User player)
        {
            Player2 = player;
            Game = new Game(Row, Col, Player1, Player2, Player1Color, Player2Color);

            StartGame1 = true;

        }
        public void DetrimineSize(int index)
        {
            switch (index)
            {
                case 1:
                    Row = 7;
                    Col = 8;

                    break;
                case 2:
                    Row = 7;
                    Col = 9;
                    break;
                case 3:
                    Row = 7;
                    Col = 10;
                    break;
                default:
                    Row = 6;
                    Col = 7;
                    break;
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
        public  void SendRoom(BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(this);

            binaryWriter.Write(strJson);

        }
        public  static Room  ReceiveRoom(String s)
        {

            return JsonConvert.DeserializeObject<Room>(s);

        }

        public static Room FindRoomInListOfRoom(string roomName)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                MessageBox.Show(rooms[i].RoomIsFull.ToString());
                if (roomName == rooms[i].Id)
                {

                    return rooms[i];
                }
            }
            return null;
        }


        public static Room ReceiveRoom(BinaryReader receiver)
        {

            return JsonConvert.DeserializeObject<Room>(receiver.ReadString());
        }

    }
}
