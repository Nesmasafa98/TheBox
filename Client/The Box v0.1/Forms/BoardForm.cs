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
    public partial class BoardForm : Form
    {
        int _row;
        int _col;//862*435
        Brush _brush;
        Color _color;
        Brush _elipsBrush;
        RectangleF _rec;
        float _width;
        float _height;
        float _xStart;
        float _yStart;
        float _xEnd;
        float _yEnd;
        float _gabX;
        float _elipsWidth;
        float _elipsHight;
        float _gabY;
        public BoardForm()
        {
            InitializeComponent();
            SetColorForBrush();
            _row = 6;
            _col = 7;
            InitializeAxisValues();

        }
        public BoardForm(int index)
        {
            InitializeComponent();
            SetColorForBrush();
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

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBoard();
            DrawElipses();
        }

        private void SetColorForBrush()
        {
            _color = Color.FromArgb(0, 150, 136);
            _brush = new SolidBrush(_color);
            _elipsBrush = new SolidBrush(Color.FromArgb(39, 39, 58));
        }

        private void InitializeAxisValues()
        {
            _xEnd = this.Width - 50;
            _yEnd = this.Height-50;
            _xStart = 200;
            _yStart = 100;
            _width = _xEnd - _xStart;
            _height = _yEnd - _yStart;
            _rec = new RectangleF(_xStart, _yStart, _width, _height);
            _gabX = (_width - ((_width / (_col + 3)) * _col)) / (_col);
            _elipsWidth = (_width / (_col + 3));
            _gabY = (_height - ((_height / (_row + 3)) * _row)) / (_row);
            _elipsHight = (_height / (_row + 3));
        }

        void DrawElipses()
        {
            InitializeAxisValues();
            Graphics graphics = this.CreateGraphics();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    graphics.FillEllipse(_elipsBrush, (float)(0.5 *_gabX + _xStart + (_gabX+_elipsWidth) * j), (float)(0.5 * _gabY + _yStart + (_gabY + _elipsHight) * i), _elipsWidth, _elipsHight);

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
        void DrawBoard()
        {
            InitializeAxisValues();
            Graphics g = this.CreateGraphics();
            g.FillRectangle(_brush, _rec);
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
            //Invalidate();
        }

        private void CloseAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoardForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void BoardForm_MouseClick(object sender, MouseEventArgs e)
        {
            Color pColor = new Color();

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
