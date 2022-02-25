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
        System.Threading.Timer PlayerTimer;
        public Game game;
        //instance of Game
        //Game game1 = new Game();
        //List of Games to save and redraw with
        protected List<Game> pieces;
        Graphics graphics;
        private Color pieceColor;
        bool Iswatcher;
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
        public User Creator;
        int constant;
        int index;
        Room WatcherRoom;

        
       // bool Iswinner=false;
        System.Threading.Timer watcherTimer;
        
        PlayForm playForm;
        RoomForm roomForm;

//        public static state[,] temp;
        Thread receiverloopThread;
        Thread checkWinner;
      
        public BoardForm(User Creator, Game game, PlayForm pForm, RoomForm rForm,bool Iswatcher)
        {

            InitializeComponent();
            SetColorForBrush();
            InitializeAxisValues();
            rForm.Player1_Name.Text = game.User1.Username;
            rForm.Player2_Name.Text = game.User2.Username;
            rForm.Player1_Color.Text = game.PieceColor1Plater1.ToString();
            rForm.Player2_Color.Text = game.PieceColor1Plater2.ToString();
            Control.CheckForIllegalCrossThreadCalls = false;
            
            _row = game.Row; _col = game.Col;
            this.game = game;
           // temp = game.boardState;
            this.Creator = Creator;

            this.Iswatcher = Iswatcher;
            playForm = pForm;
            roomForm = rForm;
            pieceColor = Color.Red; 

            receiverloopThread = new Thread(() => game.ReceiveStateOfOthterPlayer(this));


            checkWinner = new Thread(() => CheckWhoIsWin(this));

            if (Iswatcher)
            {
                watcherTimer = new System.Threading.Timer(WatcherFunction, null, 0, 1000);
            }



            GameReceiveingConfigration(Iswatcher, game, Creator ,receiverloopThread, checkWinner, PlayerTimer);



        }

            public void WatcherFunction(object o)
        {

            ((ClientSocketInterface)Creator.socket1).SendRequest("Watch");

            WatcherRoom = ((ClientSocketInterface)Creator.socket1).ResponseWatch(
                 Creator.Room.Id);

            game = WatcherRoom.Game;

            DrawElipsesThrowGame(WatcherRoom.Game.BoardState);

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBoard();
            DrawElipses();



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

            lock (threadLock)
            {
                graphics.FillEllipse(_elipsBrush, xCoor, yCoor, _elipsWidth, _elipsHight);
            }
        }




        public void  DrawElipsesThrowGame(Game.state[,] boardState)
        {
            Color color2;

            InitializeAxisValues();
            graphics = this.CreateGraphics();
            {
                
                {
                    for (int i = 0; i < _row; i++)
                    {
                        for (int j = 0; j < _col; j++)
                        {
                            color2 = Color.FromArgb(39, 39, 58);
                            if (boardState[j, i] == Game.state.player1)
                            {
                                color2 = game.PieceColor1Plater1;
                            }
                            else
                            if (boardState[j, i] == Game.state.player2)
                            {
                                color2 = game.PieceColor1Plater2;
                            }
                            DrawElipse(i, j, color2);
                        }
                    }
                }
            }
        }


        private void BoardForm_MouseClick(object sender, MouseEventArgs e)
        {

            constant = this.Width / _col;
            index = e.X / constant;
            // Game piece = new Game(e.X, e.Y, pcolor);
            
            if (game.full[index] >= 0)
            {




                
                if (Creator.Username == this.game.User1.Username)
                {

                    if (Game.IsStateChanged(game.Prev, game.BoardState, game.Row, game.Col))
                    {
                        game.drawGamePiece(index, graphics, this, game.PieceColor1Plater1, Game.state.player1);


                        game.SendGame(ClientSocket.streamWriter);
                        game.Prev = game.BoardState;    
                        

                    }

                }
                else
                {
                    if (Game.IsStateChanged(game.Prev, game.BoardState, game.Row, game.Col))
                    {

                        game.drawGamePiece(index, graphics, this, Color.Green, Game.state.player2);

                        game.SendGame(ClientSocket.streamWriter);
                        game.Prev = game.BoardState;


                    }
                        
                    
                }
                DrawElipsesThrowGame(game.BoardState);
            }


            if (game.WinningPlayer() == "player1")
            {
                MessageBox.Show("Red Player Wins,  Beats blue");
                MessageBox.Show("Hard Luck blue");
                //  ChooseToResetOrNot();
            }
            else if (game.WinningPlayer() == "player2")
            {
                MessageBox.Show("Blue Player Wins", "Blue Beat Red");
                MessageBox.Show("Hard Luck red");
                //ChooseToResetOrNot();
            }
        }
        public void drawallpieces(Game.state[,] mystate)
        {

            for (int i = 0; i < game.Row; i++)
            {
                for (int j = 0; j < game.Col; j++)
                {
                    if (mystate[j, i] == Game.state.player1)
                    {
                        DrawElipse(j, i, game.PieceColor1Plater1);

                    }
                    if ((mystate[j, i] == Game.state.player2))
                    {
                        //DrawElipse(i, j, Color.FromArgb(39, 39, 58));

                        DrawElipse(j, i, game.PieceColor1Plater2);
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