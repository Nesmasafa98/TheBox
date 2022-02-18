using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    public static class TextFile
    {
        static StreamWriter LogFile;

        public static void saveLogs(Room room)
        {
            if (!File.Exists("Logs.csv"))
            {
                LogFile = File.AppendText("Logs.csv");
                LogFile.WriteLine("Room Name,Player 1 Name,Player 1 State,Player 2 Name, Player 2 State, Dat");
            }
            else
            {
                LogFile = File.AppendText("Logs.csv");
                LogFile.WriteLine(room.Id + "," + room.Player2.Username + "," + "Win" + "," + room.Player2.Username + "," + "Lose");

            }
            LogFile.Close();
        }

        // room.p1 room.p2 room.state[,]
        public static void saveGame(Room room)
        {

            LogFile = File.CreateText("Game.csv");
            LogFile.WriteLine(room.Id);
            LogFile.WriteLine(room.Player1.Username);
            LogFile.WriteLine(room.Player2.Username);
            LogFile.WriteLine("state");
            LogFile.WriteLine("start");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    LogFile.Write(room.Game.BoardState[i, j].ToString() + ",");

                }
                LogFile.WriteLine("");
            }
            LogFile.WriteLine("end");


            LogFile.Close();
        }

        public static void saveRoom()
        {
            if (!File.Exists("Rooms.csv"))
            {
                LogFile = File.AppendText("Rooms.csv");
                LogFile.WriteLine("Room Name");
            }
            else
            {
                LogFile = File.AppendText("Rooms.csv");
                for (int i = 0; i < Room.avaibleRoom.Count; i++)
                {
                    LogFile.WriteLine(Room.avaibleRoom[i]);
                }

            }
            LogFile.Close();
        }

        public static void savePlayers()
        {
            if (!File.Exists("Players.csv"))
            {
                LogFile = File.AppendText("Players.csv");
                LogFile.WriteLine("Player Name");
            }
            else
            {
                LogFile = File.AppendText("Players.csv");
                for (int i = 0; i < User.players.Count; i++)
                {
                    LogFile.WriteLine(User.players[i]);
                }

            }
            LogFile.Close();
        }

    }
}
