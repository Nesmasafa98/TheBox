using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1.Forms
{
    public partial class RoomForm : Form
    {  
       protected Game game;
        //instance of Game
        //Game game1 = new Game();
        //List of Games to save and redraw with
       protected List<Game> pieces;
      
      
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
        MainForm mainForm;
        PlayForm playForm;
        public RoomForm()
        {
            InitializeComponent();
            SetColorForBrush();
            _row = 6;
            _col = 7;
            InitializeAxisValues();

        }
        public RoomForm(int index , MainForm main , PlayForm play)
        {
            InitializeComponent();
            SetColorForBrush();
            mainForm= main;
            playForm= play;
            _index = index;
            switch (index)
            {
                case 1:
                    _row = 7;
                    _col = 8;
                    
                    break;
                case 2:
                    _row = 7;
                    _col = 9;
                    break;
                case 3:
                    _row = 7;
                    _col = 10;
                    break;
                default:
                    _row = 6;
                    _col = 7;
                    break;
            }
            
            InitializeAxisValues();
            pieces = new List<Game>();
        }


        protected void SetColorForBrush()
        {
            _color = Color.FromArgb(0, 150, 136);
            _brush = new SolidBrush(_color);
            _elipsBrush = new SolidBrush(Color.FromArgb(39, 39, 58));
        }

        protected void InitializeAxisValues()
        {
            _xEnd = this.Width - 50;
            _yEnd = this.Height-50;
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

        protected void DrawElipses()
        {
            InitializeAxisValues();
            Graphics graphics = this.CreateGraphics();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    xCoor = (float)(0.5 * _gabX + _xStart + (_gabX + _elipsWidth) * j);
                    yCoor = (float)(0.5 * _gabY + _yStart + (_gabY + _elipsHight) * i);
                    //graphics.FillEllipse(_elipsBrush, (float)(0.5 *_gabX + _xStart + (_gabX+_elipsWidth) * j), (float)(0.5 * _gabY + _yStart + (_gabY + _elipsHight) * i), _elipsWidth, _elipsHight);
                    graphics.FillEllipse(_elipsBrush, xCoor, yCoor, _elipsWidth, _elipsHight);

                }
            }
        }
        #region Make Form Movable
        // To Make Form Movable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // 
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        protected void DrawBoard()
        {
            InitializeAxisValues();
            Graphics g = this.CreateGraphics();
            g.FillRectangle(_brush, _rec);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.BoardPanel.Controls.Add(childForm);
            this.BoardPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void MaximizeAppbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
            
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoardForm_Resize(object sender, EventArgs e)
        {
            BoardPanel.Width = this.Width - 247;
            BoardPanel.Height = this.Height - 150;
            Invalidate();
        }


        private void PlayBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Board(_row, _col), sender);
            //BoardPanel.Visible = false;
            game = new Game(_row, _col);
        }

        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {
            //game.drawBoard(e);
            foreach (Game piece in pieces)
            {
                piece.redrawGamePiece(e.Graphics);
            }
        }

        private void BoardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Color pcolor = new Color();
            Game piece = new Game(e.X, e.Y, pcolor, xCoor, yCoor, _elipsWidth, _elipsHight);
            BoardPanel.Visible = true;
            Graphics f = this.BoardPanel.CreateGraphics();
            //Graphics f = this.CreateGraphics();

            pcolor = Color.Red;
            pieces.Add(piece);
            game.drawGamePiece(e, f);
            if (game.player1)
            {
                pcolor = Color.Black;
                pieces.Add(piece);
            }
            else
            {
                pcolor = Color.Red;
                pieces.Add(piece);
            }

            
            /*using (Graphics f = this.BoardPanel.CreateGraphics())
            {
                game.drawGamePiece(e, f);
                if (game.player1)
                {
                    pcolor = Color.Black;
                    pieces.Add(piece);
                }
                else
                {
                    pcolor = Color.Red;
                    pieces.Add(piece);
                }

            }*/

            if (game.WinningPlayer() == Color.Red)
            {
                MessageBox.Show("Red Player Wins", "Red Beat Black", MessageBoxButtons.OK);
                game.Reset();
                panel1.Invalidate();
            }
            else if (game.WinningPlayer() == Color.Black)
            {
                MessageBox.Show("Black Player Wins", "Black Beat Red", MessageBoxButtons.OK);
                game.Reset();
                panel1.Invalidate();
            }
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
            playForm.Show();
        }
    }
}
