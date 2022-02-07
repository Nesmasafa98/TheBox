using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
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
    }
}
