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

namespace The_Box_v0._1
{
    public partial class Login : Form
    {
        float _xStartBox;
        float _yStartBox;
        float _xEndBox;
        float _yEndBox;
        float _widthBox;
        float _heightBox;
        User user1;
        public Login()
        {
            InitializeComponent();
            
        }

        // Make Form Movable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HeadLoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ///
        
        private void button1_Click(object sender, EventArgs e)
        {   
            user1 = new User(materialTextBox22.Text);
            ClientSocket.SendRequest("log");
            ClientSocket.ResponseLog(user1);
            MainForm mainForm = new MainForm(this, user1);
            MessageBox.Show("ana 3mlt recevie");
            mainForm.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
