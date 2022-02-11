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
    public partial class Board : Form
    {

        protected Game game;
        //instance of Game
        //Game game1 = new Game();
        //List of Games to save and redraw with
        protected List<Game> pieces;


        protected int _row;
        protected int _col;//862*435
        private int[,] _board;
        private RectangleF[] _boardCol;
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
        private int _turn;

        public Board(int  row , int col)
        {
            
            InitializeComponent();
            SetColorForBrush();
            _row = row; _col = col;
            InitializeAxisValues();
            _board = new int[row, col];
            _boardCol = new RectangleF[col];
            InitailizeBoardCol();
            _turn = 1;  
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
            _xEnd = this.Width ;
            _yEnd = this.Height ;
            _xStart = 0;
            _yStart = 0;
            _width = _xEnd - _xStart;
            _height = _yEnd - _yStart;
            _rec = new RectangleF(_xStart, _yStart, _width, _height);
            _gabX = (_width - ((_width / (_col + 3)) * _col)) / (_col);
            _elipsWidth = (_width / (_col + 3));
            _gabY = (_height - ((_height / (_row + 3)) * _row)) / (_row);
            _elipsHight = (_height / (_row + 3));
        }

        void InitailizeBoardCol()
        {
            for (int i = 0; i < _col; i++)
            {
                _boardCol[i] = new RectangleF (_xStart+((_gabX+ _elipsWidth)* i), _yStart,_gabX+_elipsWidth, _height);
            }
        }
        protected void DrawElipses()
        {
            InitializeAxisValues();
            
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    DrawElips(_elipsBrush, i, j);

                }
            }
        }

        private void DrawElips(Brush solidBrush,int i, int j)
        {
            Graphics graphics = this.CreateGraphics();
            xCoor = (float)(0.5 * _gabX + _xStart + (_gabX + _elipsWidth) * j);
            yCoor = (float)(0.5 * _gabY + _yStart + (_gabY + _elipsHight) * i);
            //graphics.FillEllipse(_elipsBrush, (float)(0.5 *_gabX + _xStart + (_gabX+_elipsWidth) * j), (float)(0.5 * _gabY + _yStart + (_gabY + _elipsHight) * i), _elipsWidth, _elipsHight);
            graphics.FillEllipse(solidBrush, xCoor, yCoor, _elipsWidth, _elipsHight);
        }

        protected void DrawBoard()
        {
            InitializeAxisValues();
            Graphics g = this.CreateGraphics();
            g.FillRectangle(_brush, _rec);
        }
        int DetectCol(Point point)
        {
            for (int i = 0; i < _col; i++)
            {
                if (point.X >= _boardCol[i].X && point.Y >= _boardCol[i].Y)
                {
                    if (point.X < (_boardCol[i].X + _boardCol[i].Width) && point.Y < (_boardCol[i].Y + _boardCol[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        int GetTheEmptyRow(int col)
        {
            for (int i = _row-1; i >= 0; i--)
            {
                if (_board[i,col]== 0)
                {
                    return i;
                }
            }
            return -1;
        }
        int WinnerPlayer(int player)
        {
            // check Vertical & 
            for (int i = 0; i < _row-3; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    if (CheckEquality(player , _board[i, j] , _board[i+1, j], _board[i+2, j], _board[i+3, j]) )
                        
                    {
                        return player;
                    }

                }
            }
            //check Horizontal
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col-3; j++)
                {
                    if ( CheckEquality(player, _board[i, j], _board[i, j + 1], _board[i, j + 2], _board[i, j + 3]))
                    {
                        return player;
                    }

                }
            }
            // Top left \ 
            for (int i = 0; i < _row-3; i++)
            {
                for (int j = 0; j < _col-3; j++)
                {
                    if (CheckEquality(player, _board[i, j], _board[i + 1, j+1], _board[i + 2, j+2], _board[i + 3, j+3]))
                        
                    {
                        return player;
                    }

                }
            }
            // top right \
            for (int i = 0; i < _row - 3; i++)
            {
                for (int j = 3; j < _col; j++)
                {
                    if (CheckEquality(player, _board[i, j], _board[i + 1, j - 1], _board[i + 2, j - 2], _board[i + 3, j - 3]))

                    {
                        return player;
                    }

                }
            }
            return -1;

        }
        bool CheckEquality(int toCheck , params int[] numbers)
        {
            foreach (var no in numbers)
            {
                if (toCheck != no)
                {
                    return false;
                }
            }
            return true;
        }
        private void Board_MouseClick(object sender, MouseEventArgs e)
        {
            int colIndex = DetectCol(e.Location);
            if (colIndex != -1)
            {
                int rowIndex = GetTheEmptyRow(colIndex);
                if (rowIndex != -1)
                {
                    _board[rowIndex, colIndex] = _turn;
                    if (_turn == 1)
                    {
                        DrawElips(new SolidBrush(Color.FromArgb(161, 32, 89)), rowIndex, colIndex);   
                    }
                    else if (_turn == 2)
                    {
                        DrawElips(new SolidBrush(Color.FromArgb(255, 87, 34)), rowIndex, colIndex);
                    }
                    int Winner = WinnerPlayer(_turn);
                    if (Winner != -1)
                    {
                        MessageBox.Show($"Gongrats, Player{_turn} Has Won");
                        Application.Restart();
                    }
                    if (_turn ==1)
                    {
                        _turn = 2;
                    }
                    else
                    {
                        _turn = 1;
                    }
                }

            }
        }
        
    }
}
