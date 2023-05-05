using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PictureViewer
{
    public partial class Picture : Form
    {
        public Picture(Image XX)
        {
            InitializeComponent();
            PB1.Image = XX;
        }

        private void Picture_Load(object sender, EventArgs e)
        {
        }
    }
}
