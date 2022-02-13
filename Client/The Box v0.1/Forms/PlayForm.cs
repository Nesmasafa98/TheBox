using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace The_Box_v0._1.Forms
{


    public partial class PlayForm : Form
    {
        System.Threading.Timer mytimer;


        //  public static List<RoomForm> roomForms;
        RoomForm roomForm;
        MainForm mainForm;
        string RoomName;
        User user;
        public static List<Room> rooms;
        public static List<User> avaibleplayerS;

        ClientSocket myclient;

        public PlayForm(MainForm mf, User u)
        {
            InitializeComponent();
            //   myclient = new ClientSocket();
            mainForm = mf;
            //      roomForms = new List<RoomForm>();
            avaibleplayerS = new List<User>();
            rooms = new List<Room>();
            user = u;
            //MessageBox.Show("ana 3mlt recevie");
            ClientSocket.SendRequest("showRooms");
            ClientSocket.ResponseShowRooms(rooms);
            ClientSocket.SendRequest("showplayer");
            ClientSocket.ResponseShowplayer(avaibleplayerS);
            MessageBox.Show(rooms.Count.ToString());

            for (int i = 0; i < rooms.Count; i++)
            {
                listBox1.Items.Add(rooms[i].id);
            }
            for (int i = 0; i < avaibleplayerS.Count; i++)
            {
                MessageBox.Show(avaibleplayerS[i].username);
            }

            mytimer = new System.Threading.Timer(myfuntion, null, 0, 5000);
            //myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            //myTimer.Interval = 3000; // 1000 ms is one second
            //  myTimer.Start();

        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Dialog dlg = new Dialog(rooms);
            DialogResult dResult;
            dResult = dlg.ShowDialog();


            if (dResult == DialogResult.OK)
            {

                //   roomForm = new RoomForm(dlg.IndexBoardSize, dlg.RoomName, user, mainForm, this);
                Console.WriteLine("shimaaaaaaaaaaaaaaa");
                //Room CreatedRoom = new Room(user, dlg.RoomName, dlg.IndexBoardSize);
                ClientSocket.SendRequest("create");
                user.room = ClientSocket.ResponseCreate(user, dlg.RoomName, dlg.IndexBoardSize);
                roomForm = new RoomForm(user.room, mainForm, this);
                //  roomForms.Add(roomForm);
                //  MessageBox.Show(CreatedRoom.id);
                MessageBox.Show(user.room.id);
                roomForm.Show();
                //this.Hide();
                mainForm.Hide();
            }
            listBox1.Items.Clear();

            for (int i = 0; i < rooms.Count; i++)
            {
                listBox1.Items.Add(rooms[i].id);
            }

        }
        public void myfuntion(object o)
        {
          //  MessageBox.Show("allah");
        }
        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // add try and catch ti check it there are string 
            RoomName = listBox1.SelectedItem.ToString();
            for(int i=0; i< rooms.Count; i++)
            {
                if (RoomName == rooms[i].id)
                {
                    MessageBox.Show("ana da5lt hena ya saamy");
                    MessageBox.Show("allah");
                    ClientSocket.SendRequest("join");
                    user.room=ClientSocket.ResponseJoin(user, rooms[i].id);
                    roomForm = new RoomForm(user.room, mainForm, this);
                    roomForm.Show();
                    // lazem tt3dl           //    rooms[i].AskforPlay(user);
                    // lazem tt3dl              roomForms[i].Show();
                    this.Hide();
                    mainForm.Hide();
                }

            }
        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
         //   MessageBox.Show("allo");
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
