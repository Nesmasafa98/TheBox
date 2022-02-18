using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_4
{
    //return
    public class Game
    {
        private bool player1;
        private bool player2;
        private Color pieceColor1Plater1;
        private Color pieceColor1Plater2;
        private User creatorUser;
        public enum state { empty = 0, player1 = 1, player2 = 2 };
        private state[,] boardState;

        private state[,] prev;
        private List<int> full = new List<int>();

        //int X;        
        private int row;
        private int col;
        private User user1;
        private User user2;

        public bool Player1 { get => player1; set => player1 = value; }
        public bool Player2 { get => player2; set => player2 = value; }
        public Color PieceColor1Plater1 { get => pieceColor1Plater1; set => pieceColor1Plater1 = value; }
        public Color PieceColor1Plater2 { get => pieceColor1Plater2; set => pieceColor1Plater2 = value; }
        public User CreatorUser { get => creatorUser; set => creatorUser = value; }
        public state[,] BoardState { get => boardState; set => boardState = value; }
        public state[,] Prev { get => prev; set => prev = value; }
        public List<int> Full { get => full; set => full = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public User User1 { get => user1; set => user1 = value; }
        public User User2 { get => user2; set => user2 = value; }

        //   public bool Iswinner=false;


        public Game(int r, int c, User u1, User u2)
        {
            Player1 = true;
            Player2 = false;
            User1 = u1;
            User2 = u2;

            Row = r;
            Col = c;
            //pieceColor1Plater1 = Color.FromName(player1Color);
            PieceColor1Plater2 = Color.Green;
            BoardState = new state[Col, Row];
            for (int i = 0; i < Col; i++)
            {
                Full.Add(Row - 1);
            }
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    BoardState[i, j] = state.empty;
                }
            }
        }


        //Method that changes the players turn and game piece color
        public void playerTurn()
        {
            Player1 = !Player1;
            Player2 = !Player2;
            if (Player1)
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
            Player1 = true;
            Player2 = false;
            //  pieceColor = Color.Red;
            for (int i = 0; i < Col; i++)
            {
                Full[i] = Row - 1;
            }
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    BoardState[i, j] = state.empty;
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

        public bool Iswinner()
        {
            if (WinningPlayer()== "NoWinner!")
            {
              //  MessageBox.Show(WinningPlayer().ToString());

                return false;
            }
            else

                return true;


        }

        public String WinningPlayer()
        {
            bool Playerone = false;
            bool playertwo = false;
            //vertical win
            for (int i = 0; i < BoardState.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < BoardState.GetLength(1); j++)
                {
                    if (BoardState[i, j] == state.player1 && BoardState[i + 1, j] == state.player1 && BoardState[i + 2, j] == state.player1 && BoardState[i + 3, j] == state.player1)
                    {
                        Playerone = true;
                    }
                    if (BoardState[i, j] == state.player2 && BoardState[i + 1, j] == state.player2 && BoardState[i + 2, j] == state.player2 && BoardState[i + 3, j] == state.player2)
                    {
                        playertwo = true;
                    }
                }
            }


            //horizontal win
            for (int j = 0; j < BoardState.GetLength(1) - 3; j++)
            {
                for (int i = 0; i < BoardState.GetLength(0); i++)
                {
                    if (BoardState[i, j] == state.player1 && BoardState[i, j + 1] == state.player1 && BoardState[i, j + 2] == state.player1 && this.BoardState[i, j + 3] == state.player1)
                    {
                        Playerone = true;
                    }
                    else if (BoardState[i, j] == state.player2 && BoardState[i, j + 1] == state.player2 && BoardState[i, j + 2] == state.player2 && this.BoardState[i, j + 3] == state.player2)
                    {
                        playertwo = true;
                    }
                }
            }


            //ascending diagonal 
            for (int i = 3; i < BoardState.GetLength(0); i++)
            {
                for (int j = 0; j < BoardState.GetLength(1) - 3; j++)
                {
                    if (BoardState[i, j] == state.player1 && this.BoardState[i - 1, j + 1] == state.player1 && BoardState[i - 2, j + 2] == state.player1 && BoardState[i - 3, j + 3] == state.player1)
                    {
                        Playerone = true;
                    }
                    else if (BoardState[i, j] == state.player2 && this.BoardState[i - 1, j + 1] == state.player2 && BoardState[i - 2, j + 2] == state.player2 && BoardState[i - 3, j + 3] == state.player2)
                    {
                        playertwo = true;
                    }
                }
            }

            //descending diagonal
            for (int i = 3; i < BoardState.GetLength(0); i++)
            {
                for (int j = 3; j < BoardState.GetLength(1); j++)
                {
                    if (BoardState[i, j] == state.player1 && BoardState[i - 1, j - 1] == state.player1 && BoardState[i - 2, j - 2] == state.player1 && BoardState[i - 3, j - 3] == state.player1)
                    {
                        Playerone = true;
                    }
                    if (BoardState[i, j] == state.player2 && BoardState[i - 1, j - 1] == state.player2 && BoardState[i - 2, j - 2] == state.player2 && BoardState[i - 3, j - 3] == state.player2)
                    {
                        playertwo = true;
                    }

                }
            }

            if (Playerone)
                return "player1";
            else if (playertwo)
                return "player2";
            else
                return "NoWinner!";
        }
    }
    }
