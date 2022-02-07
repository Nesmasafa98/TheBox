using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Box_v0._1
{
    public class Room
    {
        string roomName;
        User Player1;
        User Player2;
        User[] Watchers;
        Forms.BoardForm board;
        bool StartGame = false;
        Game game;

        public Room(User owner, string name, int index)
        {
            Player1 = owner;
            roomName = name;
            game = new Game(index);
            //board = new Forms.BoardForm(index);
        }

        public void PlayBtn(User player)
        {
            Player2 = player;
            StartGame = true;
            //game = new Game();
        }
    }
}
