using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public partial class Dialog : Form
    {
        string BoardSize;
        string roomName;
        Room room;
        MainForm mainForm;
        User player;
        public Dialog()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        public Dialog(MainForm mainFrm, User pl)
        {
            InitializeComponent();
            player = pl;
            mainForm = mainFrm;
        }
        public string RoomName
        {
            get
            {
                return roomName;
            }
            set
            {
                roomName = value;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            roomName = materialTextBox21.Text;
            if(radioButton1.Checked)
            {
                BoardSize = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                BoardSize = radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                BoardSize = radioButton3.Text;
            }
            room = new Room(player, roomName, BoardSize);
            //PlayGame playGame = new PlayGame();
            //playGame.Show();
            //mainForm.Hide();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
