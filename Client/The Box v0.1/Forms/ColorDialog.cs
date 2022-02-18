using System;
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
    public partial class ColorDialog : Form
    {
        public string P2Color { set; get; }
        public ColorDialog(string p1Color)
        {
            InitializeComponent();
            RemoveColor(p1Color);
        }

        public void DetermineColor()
        {
            if (radioButton6.Checked)
            {
                P2Color = radioButton6.Text;
            }
            else if (radioButton5.Checked)
            {
                P2Color = radioButton5.Text;
            }
            else if (radioButton4.Checked)
            {
                P2Color = radioButton4.Text;
            }
            else if (radioButton7.Checked)
            {
                P2Color = radioButton7.Text;
            }
        }

        public void RemoveColor(string p1Color)
        {
            if (radioButton6.Text == p1Color)
            {
                radioButton6.Enabled = false;
                radioButton5.Checked = true;

            }
            else if (radioButton5.Text == p1Color)
            {
                radioButton5.Enabled = false;
                radioButton6.Checked = true;

            }
            else if (radioButton7.Text == p1Color)
            {
                radioButton7.Enabled = false;
                radioButton6.Checked = true;

            }
            else if (radioButton4.Text == p1Color)
            {
                radioButton4.Enabled = false;
                radioButton6.Checked = true;

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            DetermineColor();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ColorDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
