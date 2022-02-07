using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourServer
{
    public class Room
    {
        string roomName;
        User Player1;
        User Player2;
        User[] Watchers;
        Board board;
        bool StartGame = false;
        Game game;

        public Room(User owner, string name, string size)
        {
            Player1 = owner;
            roomName = name;
            board = new Board(size);
        }

        public void PlayBtn(User player)
        {
            Player2 = player;
            StartGame = true;
            game = new Game();
        }
    }
}
