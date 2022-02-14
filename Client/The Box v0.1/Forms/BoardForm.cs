using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        protected int _index;

        int constant;
        int index;

        PlayForm playForm;
        RoomForm roomForm;

        public BoardForm(User Creator,Game game, PlayForm pForm, RoomForm rForm)
        {

            InitializeComponent();
            SetColorForBrush();
            InitializeAxisValues();
            this.game = game;
            this.game.creatorUser = Creator;
            
            MessageBox.Show("Ya samy " + true);
            if (Creator.username == this.game.user1.username)
            {

                MessageBox.Show("Ya samy " + true);
            }
            _row = game.row; _col = game.col;
            pieceColor = Color.Red;
        //    game = new Game(_row, _col, user1, user2);
          //  pieces = new List<Game>();
            playForm = pForm;
            roomForm = rForm;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBoard();
            DrawElipses();
            drawallpieces();
           // Console.Write("samy");
            
            
         //   MessageBox.Show("ana Hena ya samy");
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
        

        
        private void BoardForm_MouseClick(object sender, MouseEventArgs e)
        {
            Color pcolor = new Color();
            
            constant = this.Width / _col;
            index = e.X / constant;
           // Game piece = new Game(e.X, e.Y, pcolor);
            
            if(game.full[index]>=0)
            {
              drawallpieces();
                game.drawGamePiece(index, graphics, this);
                game.playerTurn();
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
        public void drawallpieces()
        {

            for (int i = 0; i < game.col; i++)
            {
                for (int j = 0; j < game.row; j++)
                {
                    if (game.boardState[i, j] == Game.state.player1)
                    {
                        //DrawElipse(i, j, game.pieceColor1Plater1);
                        DrawElipse(i, j, Color.FromArgb(39, 39, 58));

                    }
                    if ((game.boardState[i, j] == Game.state.player2))
                    {
                        DrawElipse(i, j, Color.FromArgb(39, 39, 58));

                        //   DrawElipse(i, j, game.pieceColor1Plater2);
                    }
                    else

                        DrawElipse(i, j, Color.FromArgb(39, 39, 58));
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
        //public void choosetoresetornot()
        //{
        //    dialogresult resultp1 = messagebox.show("do you want to play again?", "repeat game", messageboxbuttons.yesno, messageboxicon.question);
        //    dialogresult resultp2 = messagebox.show("do you want to play again?", "repeat game", messageboxbuttons.yesno, messageboxicon.question);
        //    if (resultp1 == dialogresult.yes && resultp2 == dialogresult.yes)
        //    {
        //        game.reset();
        //        invalidate();
        //    }
        //    else if (resultp1 == dialogresult.no && resultp2 == dialogresult.no)
        //    {
        //        for (int i = 0; i < playform.roomforms.count(); i++)
        //        {
        //            if (roomform.roomname == playform.roomforms[i].roomname)
        //            {
        //                playform.listbox1.items.remove(playform.roomforms[i].roomname);
        //                playform.roomforms.remove(playform.roomforms[i]);
        //            }
        //        }
        //        this.hide();
        //        playform.mainform.show();
        //        playform.show();
        //        invalidate();
        //    }
        //    else if (resultp1 == dialogresult.yes && resultp2 == dialogresult.no)
        //    {

        //    }
        //    else if (resultp1 == dialogresult.no && resultp2 == dialogresult.yes)
        //    {

        //    }
        //}
    }
}