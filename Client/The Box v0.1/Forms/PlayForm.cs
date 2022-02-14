using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace The_Box_v0._1.Forms
{


    public partial class PlayForm : Form
    {
        System.Threading.Timer mytimer;


        public static List<RoomForm> roomForms;
        RoomForm roomForm;
        public MainForm mainForm;
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
            //     roomForms = new List<RoomForm>();
            avaibleplayerS = new List<User>();
            rooms = new List<Room>();
            user = u;
            Control.CheckForIllegalCrossThreadCalls = false;
            //MessageBox.Show("ana 3mlt recevie");
            renderAvailableRooms();
            renderAvailableUsers();
            //ClientSocket.SendRequest("showplayer");
            //ClientSocket.ResponseShowplayer(avaibleplayerS);
            MessageBox.Show(rooms.Count.ToString());

            //for (int i = 0; i < avaibleplayerS.Count; i++)
            //{
            //    MessageBox.Show(avaibleplayerS[i].username);
            //}

            //for (int i = 0; i < Login.allUsers.Count(); i++)
           // {
             //   listBox3.Items.Add(Login.allUsers[i].UserName);
            //}

            mytimer = new System.Threading.Timer(clientThread, null, 0, 5000);
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
                disallowTimer();
                ClientSocket.SendRequest("create");
                Room m = ClientSocket.ResponseCreate(user, dlg.RoomName, dlg.IndexBoardSize);
                user.room = m;
                roomForm = new RoomForm(user,user.room, mainForm, this);
                //roomForms.Add(roomForm);
                  MessageBox.Show("5la baaaaaaaaaalk");
                //MessageBox.Show(m.Player1.UserName);
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
        public void clientThread(object o)
        {
            
            renderAvailableRooms();
            renderAvailableUsers();
            
            //MessageBox.Show(rooms.Count.ToString());

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
                    disallowTimer();
                    ClientSocket.SendRequest("join");
                   
                    user.room=ClientSocket.ResponseJoin(user, rooms[i].id);
                    roomForm = new RoomForm(user,user.room, mainForm, this);
                    roomForm.Show();

                    roomForm.PlayBtn.Hide();
                    // lazem tt3dl           //    rooms[i].AskforPlay(user);
                    // lazem tt3dl              roomForms[i].Show();
                    this.Hide();
                    mainForm.Hide();
                }

            }
        }

        public void renderAvailableRooms()
        {
            
                rooms.Clear();
                ClientSocket.SendRequest("showRooms");
                ClientSocket.ResponseShowRooms(rooms);

                listBox1.Items.Clear();
                for (int i = 0; i < rooms.Count; i++)
                {
                    listBox1.Items.Add(rooms[i].id);
                }
            
        }
        public void renderAvailableUsers()
        {

            avaibleplayerS.Clear();
            ClientSocket.SendRequest("showplayer");
            ClientSocket.ResponseShowplayer(avaibleplayerS);

            listBox3.Items.Clear();
            for (int i = 0; i < avaibleplayerS.Count; i++)
            {
                // MessageBox.Show(avaibleplayerS[i].username);
                listBox3.Items.Add(avaibleplayerS[i].username);
            }

        }

        public void disallowTimer()
        { 
         

                    mytimer.Change(Timeout.Infinite, Timeout.Infinite);
                    
                
        }

        public  void allowTimer()
        {
            mytimer = new System.Threading.Timer(clientThread, null, 0, 5000);
        }

        public void ClientThread()
        {

            //while (true)
            //{
            //    ClientSocket.SendRequest("reloadRooms");

                
            //        ClientSocket.ResponseShowRooms(rooms);
            //        renderAvailableRooms();
                
            //}


        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
         //   MessageBox.Show("allo");
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < roomForms.Count; i++)
            //{
            //    listBox1.Items.Add(roomForms[i].RoomName);
            //}
            //Invalidate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
