using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{

    public class Game :IGame
    {

     public   bool thereIsWinner = false;
        private bool player1;
        private bool player2;
        private Color pieceColor1Plater1;
        private Color pieceColor1Plater2;
        public User creatorUser;
        public enum state { empty = 0, player1 = 1, player2 = 2 };
        private state[,] boardState;

        private state[,] prev;
        public List<int> full = new List<int>();

        //int X;        
        private int row;
        private int col;
        private User user1;
           private User user2;



        public static void CheckWhoIsWin(Forms.BoardForm boardForm)
        {
            //while (!boardForm.game.thereIsWinner)
            //{
            //    Thread.Sleep(1000);
            //    if (boardForm.game.WinningPlayer() == "player1")
            //    {
            //        MessageBox.Show("Red Player Wins,  Beats blue");
            //        boardForm.game.thereIsWinner = true;
            //        MessageBox.Show("Hard Luck blue");
            //        //  ChooseToResetOrNot();
            //    }
            //    else if (boardForm.game.WinningPlayer() == "player2")
            //    {
            //        boardForm.game.thereIsWinner = true;
            //        MessageBox.Show("Blue Player Wins", "Blue Beat Red");
            //        MessageBox.Show("Hard Luck red");
            //        //ChooseToResetOrNot();
            //    }
            //}

        }

        public Game(int r, int c, User u1, User u2, string player1Color, string player2Color)
        {
            thereIsWinner = false;
            Player1 = true;
            Player2 = false;
            User1 = u1;
            User2 = u2;
            Row = r;
            Col = c;
            //pieceColor1Plater1 = Color.Red;
            //pieceColor1Plater2 = Color.Green;
            BoardState = new state[Col, Row];
            for (int i = 0; i < Col; i++)
            {
                full.Add(Row - 1);
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

        }

        //Method to draw the individual game pieces
        // Draws red piece if player 1 and black piece if player 2




        public void Reset()
        {
            Player1 = true;
            Player2 = false;
            //  pieceColor = Color.Red;
            for (int i = 0; i < Col; i++)
            {
                full[i] = Row - 1;
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
        public  void SendGame (BinaryWriter binaryWriter)
        {

            string strJson = JsonConvert.SerializeObject(this);

            binaryWriter.Write(strJson);
        }


        public  Game Receiver(BinaryReader br)
        {

            return JsonConvert.DeserializeObject<Game>(br.ReadString());

        }





        public void drawGamePiece(int index, Graphics graphics, Forms.BoardForm boardForm, Color type, state newState)
        {
            //if (full[index] >= 0)
            //{
            if (BoardState[index, full[index]] == state.empty)
            {
                BoardState[index, full[index]] = newState;
                boardForm.DrawElipse(full[index], index, type);
                full[index]--;
                //playerTurn();


            }

            //else if (player2 && boardState[index, full[index]] == state.empty)
            //{
            //    boardState[index, full[index]] = state.player2;
            //    boardForm.DrawElipse(full[index], index, pieceColor1Plater2);
            //    full[index]--;
            //    playerTurn();
            //}
            //}
        }

        System.Threading.Timer PlayerTimer;

        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public User User1 { get => User11; set => User11 = value; }
        public User User2 { get => User21; set => User21 = value; }
        public bool Player1 { get => player1; set => player1 = value; }
        public bool Player2 { get => player2; set => player2 = value; }
        public Color PieceColor1Plater1 { get => PieceColor1Plater11; set => PieceColor1Plater11 = value; }
        public Color PieceColor1Plater2 { get => PieceColor1Plater21; set => PieceColor1Plater21 = value; }
        public state[,] BoardState { get => boardState; set => boardState = value; }
        public state[,] Prev { get => prev; set => prev = value; }
        public User User11 { get => User12; set => User12 = value; }
        public User User21 { get => User22; set => User22 = value; }
        public User User12 { get => User13; set => User13 = value; }
        public User User22 { get => User23; set => User23 = value; }
        public User User13 { get => user1; set => user1 = value; }
        public User User23 { get => user2; set => user2 = value; }
        public Color PieceColor1Plater11 { get => pieceColor1Plater1; set => pieceColor1Plater1 = value; }
        public Color PieceColor1Plater21 { get => pieceColor1Plater2; set => pieceColor1Plater2 = value; }

        public static void GameReceiveingConfigration(bool Iswatcher,Game game,User Creator,Thread receiverloopThread,Thread checkWinner, System.Threading.Timer PlayerTimer)
        {


            if (!Iswatcher)
            {
                if (Creator.Username == game.User1.Username)
                {
                    //  game.drawGamePiece(index, graphics, this, Color.Red, Game.state.player1);


                    ClientSocket.SendRequest("ConfigPlayer1");
                    ClientSocket.StateConfigPlayer1();


                }
                else
                {
                    ClientSocket.SendRequest("ConfigPlayer2");
                    ClientSocket.StateConfigPlayer2();
                   game.Prev = game.BoardState;
                   
                }

                receiverloopThread.Start();
                checkWinner.Start();
                PlayerTimer = new System.Threading.Timer(PlayerThread, null, 0, 300000);
            }



        }

        public static Boolean IsStateChanged(state[,] oldState, state[,] current, int row, int col)
        {
            if (oldState == null)
                return true;

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

            }


            return false;
        }


        //==== will change it 

        public static void PlayerThread(object o)
        {
            //   MessageBox.Show("Hi Timer");
        }

        // will change it 

        /// <summary>
        /// =
        /// </summary>
        /// <param name="o"></param>



        public String WinningPlayer()
        {
            bool  Playerone= false;
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


        public void Receiverloop(Forms.BoardForm boardForm)
        {
            while (!thereIsWinner)
            {



                if (boardForm.Creator.Username == this.User1.Username)
                {
                    //  game.drawGamePiece(index, graphics, this, Color.Red, Game.state.player1);

                    boardForm.game = (boardForm.game.Receiver(ClientSocket.streamReader));

                    boardForm.DrawElipsesThrowGame(boardForm.game.BoardState);
                    thereIsWinner = ClientSocket.streamReader.ReadBoolean();

                }

                else
                {
                    boardForm.game = boardForm.game.Receiver(ClientSocket.streamReader);
                    boardForm.DrawElipsesThrowGame(boardForm.game.BoardState);
                    thereIsWinner = ClientSocket.streamReader.ReadBoolean();

                }
            }
            boardForm.game.SendGame(ClientSocket.streamWriter);
             
            ClientSocket.SendRequest("log");
            ClientSocket.ResponseLog(boardForm.Creator);
        }
    }
}
