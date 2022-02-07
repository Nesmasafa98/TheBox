using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Box_v0._1
{
    //return
    public class Game
    {
        int BoardWidth, BoardHeight;
        public bool player1;
        public bool player2;
        private Color pieceColor;
        public enum state { empty = 0, player1 = 1, player2 = 2 };
        private state[,] boardState = new state[10, 7];
        List<int> full = new List<int> { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
        int X;
        Forms.BoardForm board;

        public Game(int index)
        {
            board = new Forms.BoardForm(index);
            BoardWidth = 1000;
            BoardHeight = 700;
            player1 = true;
            player2 = false;
            pieceColor = Color.Red;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    boardState[i, j] = state.empty;
                }
            }
        }

        public Game(int x, int y, Color pcolor)
        {
            state STATE = new state();
            if (pcolor == Color.Red)
            {
                player1 = true;
                player2 = false;
                pieceColor = Color.Red;
                STATE = state.player1;
            }
            else if (pcolor == Color.Black)
            {
                player2 = true;
                player1 = false;
                pieceColor = Color.Black;
            }

            boardState[x / 100, y / 100] = STATE;
            X = x / 100;

        }
    }
}
