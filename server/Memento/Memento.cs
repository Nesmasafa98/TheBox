using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
   public class Memento
    {
        private Game.state[,] boardState;

        public Memento(Game.state[,] state)
        {
            boardState = state;

        }

        public Game.state[,] GetState()
        {
            return boardState;
        }




    }
}
