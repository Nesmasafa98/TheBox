using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        float xCoordinate;
        float yCoordinate;
        float elipsWidth;
        float elipsHeight;
        int row;
        int col;


        Forms.RoomForm board;

        public Game(int r, int c)
        {
            player1 = true;
            player2 = false;
            row = r;
            col = c;
            pieceColor = Color.Red;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    boardState[i, j] = state.empty;
                }
            }
        }

        public Game(int x, int y, Color pcolor, float xC, float yC, float eW, float eH)
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
            xCoordinate = xC;
            yCoordinate = yC;
            elipsWidth = eW;
            elipsHeight = eH;
        }

        //Method that changes the players turn and game piece color
        private void playerTurn()
        {
            player1 = !player1;
            player2 = !player2;
            if (player1)
            {
                pieceColor = Color.Red;
            }
            else
            {
                pieceColor = Color.Black;
            }
        }

        //Method to draw the individual game pieces
        // Draws red piece if player 1 and black piece if player 2

        public void drawGamePiece(MouseEventArgs e, Graphics f)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(pieceColor);
            int xlocal = (e.X / 100);

            if (full[xlocal] >= 0)
            {

                if (player1 && boardState[xlocal, full[xlocal]] == state.empty)
                {
                    boardState[xlocal, full[xlocal]] = state.player1;
                    //f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);
                    f.FillEllipse(myBrush, xCoordinate, yCoordinate, elipsWidth, elipsHeight);
                    full[xlocal]--;
                    playerTurn();
                }
                else if (player2 && boardState[xlocal, full[xlocal]] == state.empty)
                {
                    boardState[xlocal, full[xlocal]] = state.player2;
                    //f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);
                    f.FillEllipse(myBrush, xCoordinate, yCoordinate, elipsWidth, elipsHeight);
                    full[xlocal]--;
                    playerTurn();
                }
            }
        }

        //Method to redraw the pieces after maximization
        public void redrawGamePiece(Graphics f)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(pieceColor);
            int xlocal = (X / 100);

            if (full[xlocal] >= 0)
            {
                if (player1)
                {
                    boardState[xlocal, full[xlocal]] = state.player1;
                    //f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);
                    f.FillEllipse(myBrush, xCoordinate, yCoordinate, elipsWidth, elipsHeight);

                }
                else if (player2)
                {
                    boardState[xlocal, full[xlocal]] = state.player2;
                    //f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);
                    f.FillEllipse(myBrush, xCoordinate, yCoordinate, elipsWidth, elipsHeight);

                }
            }
        }

        public void drawBoard(PaintEventArgs e)
        {
            Pen line = new Pen(Color.Black);
            int lineXi = 197, lineXf = this.BoardWidth;
            int lineYi = 100, lineYf = this.BoardHeight;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //for (int startY = 197; startY <= BoardWidth; startY += 100)
            for (float startY = 100; startY <= BoardWidth; startY += yCoordinate/(row-1))
            {
                e.Graphics.DrawLine(line, startY, lineYi, startY, lineYf);
            }

            //for (int startX = 100; startX <= BoardHeight; startX += 100)
            for (float startX = 197; startX <= BoardHeight; startX += xCoordinate/(col-1))

            {
                e.Graphics.DrawLine(line, lineXi, startX, lineXf, startX);
            }

            for (float y = 100; y <= BoardHeight; y += yCoordinate / (row - 1))
            {
                for (float x = 197; x <= BoardWidth; x += xCoordinate / (col - 1))
                {
                    e.Graphics.FillEllipse(myBrush, new RectangleF(x, y, elipsWidth, elipsHeight));
                }
            }
        }

        public void Reset()
        {
            full = new List<int>(col) { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
            player1 = true;
            player2 = false;
            pieceColor = Color.Red;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    boardState[i, j] = state.empty;
                }
            }
        }
        public Color WinningPlayer()
        {
            bool RedPlayer = false;
            bool BlackPlayer = false;
            //vertical win
            for (int i = 0; i < boardState.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < boardState.GetLength(1); j++)
                {
                    if (boardState[i, j] == state.player1 && boardState[i + 1, j] == state.player1 && boardState[i + 2, j] == state.player1 && boardState[i + 3, j] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    if (boardState[i, j] == state.player2 && boardState[i + 1, j] == state.player2 && boardState[i + 2, j] == state.player2 && boardState[i + 3, j] == state.player2)
                    {
                        BlackPlayer = true;
                    }
                }
            }

            //horizontal win
            for (int j = 0; j < boardState.GetLength(1) - 3; j++)
            {
                for (int i = 0; i < boardState.GetLength(0); i++)
                {
                    if (boardState[i, j] == state.player1 && boardState[i, j + 1] == state.player1 && boardState[i, j + 2] == state.player1 && this.boardState[i, j + 3] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    else if (boardState[i, j] == state.player2 && boardState[i, j + 1] == state.player2 && boardState[i, j + 2] == state.player2 && this.boardState[i, j + 3] == state.player2)
                    {
                        BlackPlayer = true;
                    }
                }
            }


            //ascending diagonal 
            for (int i = 3; i < boardState.GetLength(0); i++)
            {
                for (int j = 0; j < boardState.GetLength(1) - 3; j++)
                {
                    if (boardState[i, j] == state.player1 && this.boardState[i - 1, j + 1] == state.player1 && boardState[i - 2, j + 2] == state.player1 && boardState[i - 3, j + 3] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    else if (boardState[i, j] == state.player2 && this.boardState[i - 1, j + 1] == state.player2 && boardState[i - 2, j + 2] == state.player2 && boardState[i - 3, j + 3] == state.player2)
                    {
                        BlackPlayer = true;
                    }
                }
            }

            //descending diagonal
            for (int i = 3; i < boardState.GetLength(0); i++)
            {
                for (int j = 3; j < boardState.GetLength(1); j++)
                {
                    if (boardState[i, j] == state.player1 && boardState[i - 1, j - 1] == state.player1 && boardState[i - 2, j - 2] == state.player1 && boardState[i - 3, j - 3] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    if (boardState[i, j] == state.player2 && boardState[i - 1, j - 1] == state.player2 && boardState[i - 2, j - 2] == state.player2 && boardState[i - 3, j - 3] == state.player2)
                    {
                        BlackPlayer = true;
                    }

                }
            }

            if (RedPlayer)
                return Color.Red;
            else if (BlackPlayer)
                return Color.Black;
            else
                return Color.Empty;
        }
    }
}
