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
        MainForm mainForm;
        string RoomName;
        //ArrayList myAL;
        RoomForm room1;
        RoomForm room2;
        RoomForm room3;

        List<RoomForm> myAL;

        public PlayForm(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
            myAL = new List<RoomForm>();

            room1 = new RoomForm(0, "Room 1");
            room2 = new RoomForm(1, "Room 2");
            room3 = new RoomForm(2, "Room 3");

            myAL.Add(room1);
            myAL.Add(room2);
            myAL.Add(room3);
            
            for (int i = 0; i < myAL.Count; i++)
            {
                listBox1.Items.Add(myAL[i].RoomName);
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Dialog dlg = new Dialog();
            DialogResult dResult;
            dResult = dlg.ShowDialog();
            
            if (dResult == DialogResult.OK)
            {
                

                //Forms.RoomForm boardForm = new RoomForm(dlg.IndexBoardSize, mainForm , this);
                Forms.RoomForm boardForm = new RoomForm(dlg.IndexBoardSize, dlg.RoomName);
                boardForm.Show();
                this.Hide();
                mainForm.Hide();
            }
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            RoomName = listBox1.SelectedItem.ToString();
            for(int i=0; i< myAL.Count; i++)
            {
                if (RoomName == myAL[i].RoomName)
                {
                    myAL[i].Show();
                    this.Hide();
                    mainForm.Hide();
                }

            }

        }
    }
}
