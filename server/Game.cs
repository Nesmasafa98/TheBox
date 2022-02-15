using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    //return
    public class Game
    {
        public bool player1;
        public bool player2;
        public Color pieceColor1Plater1;
        public Color pieceColor1Plater2;
        public User creatorUser;
        public enum state { empty = 0, player1 = 1, player2 = 2 };
        public state[,] boardState;
        public List<int> full = new List<int>();

        //int X;        
        public int row;
        public int col;
        public User user1, user2;


        public Game(int r, int c, User u1, User u2, string player1Color, string player2Color)
        {
            player1 = true;
            player2 = false;
            user1 = u1;
            user2 = u2;
            row = r;
            col = c;
            pieceColor1Plater1 = Color.Red;
            pieceColor1Plater2 = Color.Green;
            boardState = new state[col, row];
            for (int i = 0; i < col; i++)
            {
                full.Add(row - 1);
            }
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    boardState[i, j] = state.empty;
                }
            }
        }


        //Method that changes the players turn and game piece color
        public void playerTurn()
        {
            player1 = !player1;
            player2 = !player2;
            if (player1)
            {
                //  pieceColor = Color.Red;
            }
            else
            {
                //    pieceColor = Color.Blue;
            }
        }

        //Method to draw the individual game pieces
        // Draws red piece if player 1 and black piece if player 2

        public static Boolean IsStateChanged(state[,] oldState, state[,] current, int row, int col)
        {
            //Boolean changed = false;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (current[i, j] != oldState[i, j])
                    {
                        Console.Write(current[i, j]);
                        return true;
                    }

                }
                Console.WriteLine();


            }
            Console.WriteLine();

            return false;
        }


        public void Reset()
        {
            player1 = true;
            player2 = false;
            //  pieceColor = Color.Red;
            for (int i = 0; i < col; i++)
            {
                full[i] = row - 1;
            }
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    boardState[i, j] = state.empty;
                }
            }
        }





        public static void sendState(state[,] state, BinaryWriter binaryWriter)
        {
            string strJson = JsonConvert.SerializeObject(state);

            binaryWriter.Write(strJson);

        }
        public static state[,] ReceiveState(BinaryReader br)
        {

            return JsonConvert.DeserializeObject<state[,]>(br.ReadString());

        }
        public static void SendGame(Game game, BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(game);

            binaryWriter.Write(strJson);
        }


        public static Game Receiver(BinaryReader br)
        {

            return JsonConvert.DeserializeObject<Game>(br.ReadString());

        }


        public Color WinningPlayer()
        {
            bool RedPlayer = false;
            bool BluePlayer = false;
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
                        BluePlayer = true;
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
                        BluePlayer = true;
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
                        BluePlayer = true;
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
                        BluePlayer = true;
                    }

                }
            }

            if (RedPlayer)
                return Color.Red;
            else if (BluePlayer)
                return Color.Blue;
            else
                return Color.Empty;
        }
    }
}
