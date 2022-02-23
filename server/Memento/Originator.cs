using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    class Originator
    {
        private Game.state[,] boardState;

        public void setState(Game.state[,] state)
        {
            this.boardState = state;

        }
        public Memento Save()
        {
            return new Memento(boardState);
        }


    }
}
