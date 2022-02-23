using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1.Forms
{
    public partial class RoomForm : Form
    {
        MainForm mainForm;
        PlayForm playForm;
        private Thread myThread;
        User owner;
        User player;
        List<User> watchers;
        Forms.BoardForm boardform;

        
        
        Brush _brush;
        Color _color;
        Brush _elipsBrush;
        Room logicalroom;
       // User ordinaryUser;
        public string RoomName
        {
            get;
            set;
        }

        public RoomForm(User myuser ,Room room, MainForm mForm, PlayForm pForm)
        {
            InitializeComponent();
            SetColorForBrush();
            logicalroom = room;
            logicalroom.DetrimineSize(room.index);
            RoomName = room.Id;
            LabelRoomName.Text = RoomName;
            Player1_Name.Text = myuser.Username;
            Player1_Color.Text = room.Player1Color;
            mainForm = mForm;
          //  ordinaryUser = myuser; 
            playForm = pForm;
          //  myThread = new Thread(new ThreadStart(MyThreadMethod));
         //   myThread.Start();
            owner = myuser;
          
        }
  
   

        //protected void DetrimineSize(int index)
        //{
        //    switch (index)
        //    {
        //        case 1:
        //            _row = 7;
        //            _col = 8;

        //            break;
        //        case 2:
        //            _row = 7;
        //            _col = 9;
        //            break;
        //        case 3:
        //            _row = 7;
        //            _col = 10;
        //            break;
        //        default:
        //            _row = 6;
        //            _col = 7;
        //            break;
        //    }
        //}

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
        
        public void OpenChildForm(Form childForm, object btnSender)
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
            owner.socket1.SendRequest("play");
            Room receiveRoom= owner.socket1.Responseplay(logicalroom.Id);
            User.CurrentRoom = receiveRoom;
            if (User.CurrentRoom != null)
            {
                //MessageBox.Show(receiveRoom.Player2.color);
                Forms.BoardForm form = new Forms.BoardForm(owner, receiveRoom.Game, playForm, this, false);
                OpenChildForm(form, sender);
            }
        }

        public void AskforPlay(User user)
        {
            MessageBox.Show(user.Username + " want to Play with you!", "Form Playing", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            //player = user;
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            mainForm.Show();
            playForm.allowTimer();
            playForm.Show();
            Invalidate();
        }

        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Player1Username_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            owner.socket1.SendRequest("Reset");
            if (boardform.game.User1.Username== owner.Username)
            {


            }
        }
    }
}


