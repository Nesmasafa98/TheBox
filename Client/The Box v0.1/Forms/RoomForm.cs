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

        public RoomForm(int index)
        {
            InitializeComponent();
            SetColorForBrush();
            DetrimineSize(index);
            pieces = new List<Game>();
        }
        protected void DetrimineSize(int index)
        {
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
        }
        /*
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
        */

        protected void SetColorForBrush()
        {
            _color = Color.FromArgb(0, 150, 136);
            _brush = new SolidBrush(_color);
            _elipsBrush = new SolidBrush(Color.FromArgb(39, 39, 58));
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
            OpenChildForm(new Forms.BoardForm(_row, _col), sender);
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
            playForm.Show();
        }
    }
}
