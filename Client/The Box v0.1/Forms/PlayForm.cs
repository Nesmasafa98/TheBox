using System;
using System.Collections;
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
    
    public partial class PlayForm : Form
    {
        public static List<RoomForm> roomForms;
        RoomForm roomForm;
        MainForm mainForm;
        string RoomName;
        User user;
        

        public PlayForm(MainForm mf, User u)
        {
            InitializeComponent();
            mainForm = mf;
            roomForms = new List<RoomForm>();
            for (int i = 0; i < roomForms.Count; i++)
            {
                listBox1.Items.Add(roomForms[i].RoomName);
            }
            user = u;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Dialog dlg = new Dialog(roomForms);
            DialogResult dResult;
            dResult = dlg.ShowDialog();
            
            if (dResult == DialogResult.OK)
            {                
                roomForm = new RoomForm(dlg.IndexBoardSize, dlg.RoomName, user, mainForm, this);
                roomForms.Add(roomForm);
                roomForm.Show();
                this.Hide();
                mainForm.Hide();
            }
            listBox1.Items.Clear();
            
            for (int i = 0; i < roomForms.Count; i++)
            {
                listBox1.Items.Add(roomForms[i].RoomName);
            }
            
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // add try and catch ti check it there are string 
            RoomName = listBox1.SelectedItem.ToString();
            for(int i=0; i< roomForms.Count; i++)
            {
                if (RoomName == roomForms[i].RoomName)
                {
                    roomForms[i].AskforPlay(user);
                    roomForms[i].Show();
                    this.Hide();
                    mainForm.Hide();
                }

            }
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
