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
      //  public static List<Room> rooms;
        public static List<User> avaibleplayerS;

        


        public PlayForm(MainForm mf, User u)
        {
            InitializeComponent();
            //   myclient = new ClientSocket();
            mainForm = mf;
            //     roomForms = new List<RoomForm>();
            avaibleplayerS = new List<User>();
            
            user = u;
            Control.CheckForIllegalCrossThreadCalls = false;
            renderAvailableRooms();
            renderFullRooms();
            renderAvailableUsers();


            //for (int i = 0; i < avaibleplayerS.Count; i++)
            //{
            //    MessageBox.Show(avaibleplayerS[i].username);
            //}

            //for (int i = 0; i < Login.allUsers.Count(); i++)
           // {
             //   listBox3.Items.Add(Login.allUsers[i].UserName);
            //}

            mytimer = new System.Threading.Timer(clientThread, null, 0, 5000);


        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Dialog dlg = new Dialog(Room.rooms);
            DialogResult dResult;
            dResult = dlg.ShowDialog();

            
            if (dResult == DialogResult.OK)
            {

                //   roomForm = new RoomForm(dlg.IndexBoardSize, dlg.RoomName, user, mainForm, this);

                //Room CreatedRoom = new Room(user, dlg.RoomName, dlg.IndexBoardSize);
                disallowTimer();
                user.socket1.SendRequest("create");
                Room m = user.socket1.ResponseCreate(user, dlg.RoomName, dlg.IndexBoardSize, dlg.P1Color);
                user.Room = m;
                roomForm = new RoomForm(user,user.Room, mainForm, this);

                roomForm.Show();
                //this.Hide();
                mainForm.Hide();
            }
            Available_Rooms_listBox.Items.Clear();

            for (int i = 0; i < Room.rooms.Count; i++)
            {
                Available_Rooms_listBox.Items.Add(Room.rooms[i].Id);
            }

        }
        public void clientThread(object o)
        {
            
            renderAvailableRooms();
            renderFullRooms();
            renderAvailableUsers();
            
            //MessageBox.Show(rooms.Count.ToString());

        }
        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // add try and catch ti check it there are string 
            if (Available_Rooms_listBox.SelectedItem != null)
            {
                RoomName = Available_Rooms_listBox.SelectedItem.ToString();
                string p1Color = getP1Color();
                
                ColorDialog dlg = new ColorDialog(p1Color);
                DialogResult dResult;
                dResult = dlg.ShowDialog();

                if (dResult == DialogResult.OK)
                {
              
                    disallowTimer();
                    user.socket1.SendRequest("join");

                    user.Room = user.socket1.ResponseJoin(user, Room.FindRoomInListOfRoom(RoomName).Id, dlg.P2Color);
                    User.CurrentRoom = user.Room;
                    if (User.CurrentRoom != null)
                    {
                        // System.Threading.Thread.Sleep(10000);
                        roomForm = new RoomForm(user, user.Room, mainForm, this);
                        roomForm.Show();
                        roomForm.OpenChildForm(new Forms.BoardForm(user, user.Room.Game, this, roomForm, false), sender);

                        roomForm.PlayBtn.Hide();

                        //  this.Hide();
                        mainForm.Hide();
                    }


                }
            }
            
        }

        public string getP1Color()
        {
            for (int i = 0; i < Room.rooms.Count; i++)
            {
                if (Room.rooms[i].Id == RoomName)
                {
                    string p1Color = Room.rooms[i].Player1Color;
                    return p1Color;
                }
            }
            return "none";
        }
        public void renderAvailableRooms()
        {
            
                Room.rooms.Clear();
            user.socket1.SendRequest("showRooms");
            user.socket1.ResponseShowRooms(Room.rooms);

                Available_Rooms_listBox.Items.Clear();
                for (int i = 0; i < Room.rooms.Count; i++)
                {
                    Available_Rooms_listBox.Items.Add(Room.rooms[i].Id);
                }
                checkFullRooms(Room.rooms);
        }

        public void renderFullRooms()
        {

            Full_Rooms_listBox.Items.Clear();
            for (int i = 0; i < Room.fullRooms.Count; i++)
            {
                Full_Rooms_listBox.Items.Add(Room.fullRooms[i].Id);
            }
            Room.fullRooms.Clear();
        }

        public void checkFullRooms(List<Room> rooms)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms[i].RoomIsFull)
                {
                    Room.fullRooms.Add(rooms[i]);

                    for (int j = 0; j < Available_Rooms_listBox.Items.Count; j++)
                    {

                        if (Available_Rooms_listBox.Items[j].ToString() == rooms[i].Id)
                        {
                            Available_Rooms_listBox.Items.RemoveAt(j);
                        }
                    }

                }
            }
        }
        public void renderAvailableUsers()
        {

            avaibleplayerS.Clear();
            user.socket1.SendRequest("showplayer");
            user.socket1.ResponseShowplayer(avaibleplayerS);

            Online_Players_listBox.Items.Clear();
            for (int i = 0; i < avaibleplayerS.Count; i++)
            {
                // MessageBox.Show(avaibleplayerS[i].username);
                Online_Players_listBox.Items.Add(avaibleplayerS[i].Username);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void Join_Button_Click(object sender, EventArgs e)
        {
            RoomName = Full_Rooms_listBox.SelectedItem.ToString();

            user.socket1.SendRequest("Watch");
            Room RecievedRoom = user.socket1.ResponseWatch(RoomName);
            //     user.room = ClientSocket.ResponseJoin(user, Room.FindRoomInListOfRoom(RoomName).id);
            //  User.CurrentRoom = user.room;
            // System.Threading.Thread.Sleep(10000);

            disallowTimer();
            roomForm = new RoomForm(user, RecievedRoom, mainForm, this);
            roomForm.Show();
            user.Room = RecievedRoom;
            roomForm.OpenChildForm(new Forms.BoardForm(user, RecievedRoom.Game, this, roomForm, true), sender);

            roomForm.PlayBtn.Hide();

            //  this.Hide();
            mainForm.Hide();

        }

        private void Full_Rooms_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Full_Rooms_listBox.SelectedItem != null)
            {
                RoomName = Full_Rooms_listBox.SelectedItem.ToString();

                //watchers code here
            }
        }

        private void Full_Rooms_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
