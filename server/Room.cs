using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Connect_4
{
    public class Room
    {
        static public List<Room> avaibleRoom = new List<Room>();
        private string id;
        private User player1;
        private User player2;
        //public Board board;
        private bool StartGame = false;
        private Game game;

        private int _row;
        private int _col;
        public int play1Accecptance = 0;
        private bool roomIsFull = false;
        private string player1Color = "red";
        private string player2Color = "green";
        public bool someOneEnter = false;
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

        public Room(User owner, string Id, int index, string p1color)
        {
            Player1 = owner;


            //     Player1.color = "red";
            this.Id = Id;
            //board = new Board(size);
            this.index = index;
            DetrimineSize(index);
            Player1Color = p1color;
        }

        public void PlayBtn(User player)
        {
            Player2 = player;
            Console.WriteLine(Player1Color + "Game");
            Game = new Game(Row, Col, Player1, Player2);
            Game.PieceColor1Plater1 = Color.FromName(Player1Color);
            Game.PieceColor1Plater2 = Color.FromName(Player2Color);

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
                if (avaibleRoom[i].Id == Id)

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
    

    public static void  addSecoondPlayTORoom(String roomId, BinaryWriter streamWriter,User player2, string p2Color)
        {

            int i = 0;
            for (; i < avaibleRoom.Count; i++)
            {
                if (avaibleRoom[i].Id == roomId)

                {
                    avaibleRoom[i].Player2Color = p2Color;
                    avaibleRoom[i].PlayBtn(player2);
                    

                    string strJson = JsonConvert.SerializeObject(avaibleRoom[i]);
                    streamWriter.Write(strJson);
                    break;
                }
            }

        }


    }
}
