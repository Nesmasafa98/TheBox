using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static The_Box_v0._1.Game;

namespace The_Box_v0._1.Forms
{
    public partial class BoardForm : Form
    {

        protected Game game;
        //instance of Game
        //Game game1 = new Game();
        //List of Games to save and redraw with
        protected List<Game> pieces;
        Graphics graphics;
        private Color pieceColor;

        protected int _row;
        protected int _col;//862*435
        protected Brush _brush;
        protected Color _color;
        private object threadLock = new object();

        protected Brush _elipsBrush;
        protected RectangleF _rec;
        protected float _width;
        protected float _height;
        protected float _xStart;
        protected float _yStart;
        protected float _xEnd;
        protected float _yEnd;
        protected float _gabX;
        protected float _elipsWidth;
        protected float _elipsHight;
        protected float _gabY;

        protected float xCoor;
        protected float yCoor;
        // public Game.state[,] mystate;
        protected int _index;
        User Creator;
        int constant;
        int index;
        int turnplayer1=1;
        int firstTime = 0;

        PlayForm playForm;
        RoomForm roomForm;
        state[,] temp;
        Thread receiverloopThread;

        public BoardForm(User Creator, Game game, PlayForm pForm, RoomForm rForm)
        {

            InitializeComponent();
            SetColorForBrush();
            InitializeAxisValues();
            rForm.Player1_Name.Text = game.user1.username;
            rForm.Player2_Name.Text = game.user2.username;
            rForm.Player1_Color.Text = game.pieceColor1Plater1.ToString();
            rForm.Player2_Color.Text = game.pieceColor1Plater2.ToString();
            
           
            this.game = game;
           // temp = game.boardState;
            this.Creator = Creator;
            //   this.mystate = game.boardState;
            //essageBox.Show("Ya samy " + true);

            receiverloopThread = new Thread(() => Receiverloop());



            _row = game.row; _col = game.col;

            pieceColor = Color.Red;



            if (Creator.username == this.game.user1.username)
            {
                //  game.drawGamePiece(index, graphics, this, Color.Red, Game.state.player1);


                ClientSocket.SendRequest("ConfigPlayer1");
                ClientSocket.StateConfigPlayer1();
                

            }
            else
            {
                ClientSocket.SendRequest("ConfigPlayer2");
                ClientSocket.StateConfigPlayer2();
                temp = game.boardState;
              
            }

            receiverloopThread.Start();


            playForm = pForm;
            roomForm = rForm;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBoard();
            DrawElipses();


        }

        private void Receiverloop()
        {
            while (true)
            {



                if (Creator.username == this.game.user1.username)
                {
                    //  game.drawGamePiece(index, graphics, this, Color.Red, Game.state.player1);
           
                        game = Game.Receiver(ClientSocket.streamReader);
                    
                        DrawElipsesThrowGame(game.boardState);
                    

                }

                else
                {
                    game = Game.Receiver(ClientSocket.streamReader);
                    DrawElipsesThrowGame(game.boardState);

                }
            }







        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }
        protected void SetColorForBrush()
        {
            _color = Color.FromArgb(0, 150, 136);
            _brush = new SolidBrush(_color);
            _elipsBrush = new SolidBrush(Color.FromArgb(39, 39, 58));
        }

        protected void InitializeAxisValues()
        {
            _xEnd = this.Width;
            _yEnd = this.Height;
            _xStart = 0;
            _yStart = 0;
            _width = _xEnd - _xStart;
            _height = _yEnd - _yStart;
            _rec = new RectangleF(_xStart, _yStart, _width, _height);

            _gabX = (_width - ((_width / (_col + 3)) * _col)) / (_col);
            _gabY = (_height - ((_height / (_row + 3)) * _row)) / (_row);

            _elipsWidth = (_width / (_col + 3));
            _elipsHight = (_height / (_row + 3));

        }

        protected void DrawBoard()
        {
            InitializeAxisValues();
            Graphics g = this.CreateGraphics();
            g.FillRectangle(_brush, _rec);
        }

        protected void DrawElipses()
        {
            InitializeAxisValues();
            graphics = this.CreateGraphics();
            SetColorForBrush();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    DrawElipse(i, j, Color.FromArgb(39, 39, 58));
                }
            }
        }
        public void DrawElipse(int i, int j, Color color)
        {
            _elipsBrush = new SolidBrush(color);
            xCoor = (float)(0.5 * _gabX + _xStart + (_gabX + _elipsWidth) * j);
            yCoor = (float)(0.5 * _gabY + _yStart + (_gabY + _elipsHight) * i);
            graphics.FillEllipse(_elipsBrush, xCoor, yCoor, _elipsWidth, _elipsHight);
        }
        public void DrawElipsesThrowGame(Game.state[,] boardState)
        {
            Color color2;

            InitializeAxisValues();
            graphics = this.CreateGraphics();

            lock (threadLock)
            {
                for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < _col; j++)
                    {
                        color2 = Color.FromArgb(39, 39, 58);
                        if (boardState[j, i] == Game.state.player1)
                        {
                            color2 = game.pieceColor1Plater1;
                        }
                        else
                        if (boardState[j, i] == Game.state.player2)
                        {
                            color2 = game.pieceColor1Plater2;
                        }
                        DrawElipse(i, j, color2);
                    }
                }
            }
        }

        public  Boolean IsStateChanged(state[,] oldState, state[,] current, int row, int col)
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

        private void BoardForm_MouseClick(object sender, MouseEventArgs e)
        {

            constant = this.Width / _col;
            index = e.X / constant;
            // Game piece = new Game(e.X, e.Y, pcolor);
            
            if (game.full[index] >= 0)
            {




                
                if (Creator.username == this.game.user1.username)
                {

                    if (IsStateChanged(temp, game.boardState, game.row, game.col))
                    {
                        game.drawGamePiece(index, graphics, this, Color.Red, Game.state.player1);

              
                            Game.SendGame(game, ClientSocket.streamWriter);
                        temp = game.boardState;    
                        

                    }

                }
                else
                {
                    if (IsStateChanged(temp, game.boardState, game.row, game.col))
                    {

                        game.drawGamePiece(index, graphics, this, Color.Green, Game.state.player2);

                        Game.SendGame(game, ClientSocket.streamWriter);
                        temp = game.boardState;
                    }
                        
                    
                }
                DrawElipsesThrowGame(game.boardState);
            }


            if (game.WinningPlayer() == Color.Red)
            {
                MessageBox.Show("Red Player Wins,  Beats blue");
                MessageBox.Show("Hard Luck blue");
                //  ChooseToResetOrNot();
            }
            else if (game.WinningPlayer() == Color.Blue)
            {
                MessageBox.Show("Blue Player Wins", "Blue Beat Red");
                MessageBox.Show("Hard Luck red");
                //ChooseToResetOrNot();
            }
        }
        public void drawallpieces(Game.state[,] mystate)
        {

            for (int i = 0; i < game.row; i++)
            {
                for (int j = 0; j < game.col; j++)
                {
                    if (mystate[j, i] == Game.state.player1)
                    {
                        DrawElipse(j, i, game.pieceColor1Plater1);

                    }
                    if ((mystate[j, i] == Game.state.player2))
                    {
                        //DrawElipse(i, j, Color.FromArgb(39, 39, 58));

                        DrawElipse(j, i, game.pieceColor1Plater2);
                    }

                }
            }
        }

        private void BoardForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        } 





        private void BoardForm_Load(object sender, EventArgs e)
        {

        }

    }
}