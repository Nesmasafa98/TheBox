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

        public BoardForm(int  row , int col)
        {
            
            InitializeComponent();
            SetColorForBrush();
            InitializeAxisValues();
            _row = row; _col = col;
            pieceColor = Color.Red;
            game = new Game(_row, _col);
            pieces = new List<Game>();
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
            graphics.FillEllipse(_elipsBrush, xCoor, yCoor, _elipsWidth, _elipsHight);
        }
        

        
        private void BoardForm_MouseClick(object sender, MouseEventArgs e)
        {
            Color pcolor = new Color();
            constant = this.Width / _col;
            index = e.X / constant;
            Game piece = new Game(e.X, e.Y, pcolor, constant);

            game.drawGamePiece(index, graphics, this);
            if (game.player1)
            {
                //_elipsBrush = new SolidBrush(pieceColor);
                //MessageBox.Show("Player 1's Turn");
                pcolor = Color.Blue;
                pieces.Add(piece);
            }
            else
            {
                //_elipsBrush = new SolidBrush(pieceColor);
                //MessageBox.Show("Player 1's Turn");
                pcolor = Color.Red;
                pieces.Add(piece);
            }

            if (game.WinningPlayer() == Color.Red)
            {
                MessageBox.Show("Red Player Wins", "Red Beat Black", MessageBoxButtons.OK);
                game.Reset();
                Invalidate();
            }
            else if (game.WinningPlayer() == Color.Blue)
            {
                MessageBox.Show("Black Player Wins", "Black Beat Red", MessageBoxButtons.OK);
                game.Reset();
                Invalidate();
            }
        }

        private void BoardForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}