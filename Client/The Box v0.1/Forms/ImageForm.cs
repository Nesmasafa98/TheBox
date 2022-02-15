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
    public partial class ImageForm : Form
    {
        public ImageForm(string path)
        {
            InitializeComponent();
            MainImage.Image = Image.FromFile(@path);
        }
    }
}
