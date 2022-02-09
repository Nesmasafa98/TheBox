//==================================================
// Tyler Sriver
// Connect 4 - Game Class
// October 31, 2014
//==================================================
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4
{
    class Game
    {
        int BoardWidth, BoardHeight;
        public bool player1;
        public bool player2;
        private Color pieceColor;
        public enum state { empty = 0, player1 = 1, player2 = 2 }; 
        private state[,] board = new state[10, 7];
        List<int> full = new List<int> { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6};
        int X;
       
        //Constructor for the game
        public Game()
        {
            BoardWidth = 1000;
            BoardHeight = 700;
            player1 = true;
            player2 = false;
            pieceColor = Color.Red;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = state.empty;
                }
            }            
        }

        //Constructor for redraw
        public Game(int x, int y, Color pcolor)
        {       
            state STATE = new state();
            if(pcolor == Color.Red)
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
            
            board[x/100,y/100] = STATE;
            X = x/100;           
            
        }
        //Method for resting the board
        public void Reset()
        {
            full = new List<int>(10) { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
            player1 = true;
            player2 = false;
            pieceColor = Color.Red;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = state.empty;
                }
            }
        }
        //Method to draw blank game board
        public void drawBoard(PaintEventArgs e)
        {
            Pen line = new Pen(Color.Black);
            int lineXi = 0, lineXf = 1000;
            int lineYi = 0, lineYf = 700;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            for (int startY = 0; startY <= BoardWidth; startY += 100)
            {
                e.Graphics.DrawLine(line, startY, lineYi, startY, lineYf);
            }

            for (int startX = 0; startX <= BoardHeight; startX += 100)
            {
                e.Graphics.DrawLine(line, lineXi, startX, lineXf, startX);
            }

            for (int y = 0; y <= 600; y += 100)
            {
                for (int x = 0; x <= 900; x += 100)
                {
                    e.Graphics.FillEllipse(myBrush, new Rectangle(x, y, 100, 100));
                }
            }           
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

                if (player1 && board[xlocal, full[xlocal]] == state.empty)
                {
                    board[xlocal, full[xlocal]] = state.player1;
                    f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);
                    full[xlocal]--;
                    playerTurn();
                }
                else if (player2 && board[xlocal, full[xlocal]] == state.empty)
                {
                    board[xlocal, full[xlocal]] = state.player2;
                    f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);
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
                    board[xlocal, full[xlocal]] = state.player1;
                    f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);                                        
                }
                else if (player2)
                {
                    board[xlocal, full[xlocal]] = state.player2;
                    f.FillEllipse(myBrush, xlocal * 100, full[xlocal] * 100, 100, 100);                   
                }
            }
        }

        //Method to check if there is a winner
        public Color WinningPlayer()
        {
            bool RedPlayer = false;
            bool BlackPlayer = false;
            //vertical win
            for (int i = 0; i < board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == state.player1 && board[i + 1,j] == state.player1 && board[i + 2,j] == state.player1 && board[i + 3,j] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    if (board[i, j] == state.player2 && board[i + 1, j] == state.player2 && board[i + 2, j] == state.player2 && board[i + 3, j] == state.player2)
                    {
                        BlackPlayer = true;
                    }
                }
            }

            //horizontal win
            for (int j = 0; j < board.GetLength(1) - 3; j++)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    if (board[i,j] == state.player1 && board[i,j + 1] == state.player1 && board[i,j + 2] == state.player1 && this.board[i,j + 3] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    else if (board[i, j] == state.player2 && board[i, j + 1] == state.player2 && board[i, j + 2] == state.player2 && this.board[i, j + 3] == state.player2)
                    {
                        BlackPlayer = true;
                    }
                }
            }

            
            //ascending diagonal 
            for (int i = 3; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    if (board[i, j] == state.player1 && this.board[i - 1, j + 1] == state.player1 && board[i - 2, j + 2] == state.player1 && board[i - 3,j + 3] == state.player1)
                        {
                        RedPlayer = true;
                    }
                    else if (board[i, j] == state.player2 && this.board[i - 1, j + 1] == state.player2 && board[i - 2, j + 2] == state.player2 && board[i - 3, j + 3] == state.player2)
                        {
                        BlackPlayer = true;
                    }
                }
            }

            //descending diagonal
            for (int i = 3; i < board.GetLength(0); i++)
            {
                for (int j = 3; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == state.player1 && board[i - 1,j - 1] == state.player1 && board[i - 2,j - 2] == state.player1 && board[i - 3,j - 3] == state.player1)
                    {
                        RedPlayer = true;
                    }
                    if (board[i, j] == state.player2 && board[i - 1, j - 1] == state.player2 && board[i - 2, j - 2] == state.player2 && board[i - 3, j - 3] == state.player2)
                    {
                        RedPlayer = true;
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

        //Method to override ToString to write information to a file
        /* public override string ToString()
         {

             return string.Format()
         }*/

        

    }
}
