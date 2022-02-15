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
        //Forms.PlayForm playForm;
        List<Room> roomForms;
        public string BoardSize { get; set; }
        int indexBoardSize;
        public int IndexBoardSize { get; set; }
        string roomName;
        MainForm mainForm;
        User player;
        public Dialog(List <Room> rForms)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
          //  roomForms = new List<Forms.RoomForm>();
            roomForms = rForms;
            //playForm = pForm;
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
            roomName = Room_Name.Text;
            
            if (radioButton1.Checked)
            {
                IndexBoardSize = 1;
            }
            else if(radioButton2.Checked)
            {
                IndexBoardSize = 2;
            }
            else if(radioButton3.Checked)
            {
                IndexBoardSize = 3;
            }

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void MaterialTextBox21_TextChanged(object sender, EventArgs e)
        {
            int flag = 1;
            for (int i = 0; i < roomForms.Count && flag ==1; i++)
            {
                if (Room_Name.Text == roomForms[i].id)
                {
                    labelError.Visible = true;
                    labelError.Text = "Invaled";
                    button1.Enabled = false;
                    flag = 0;
                }
                else
                {
                    labelError.Visible = false;
                    labelError.Text = "";
                    roomName = Room_Name.Text;
                    button1.Enabled = true;
                }
            }
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }
    }
}
