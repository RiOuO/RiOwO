using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_DrawPaint
{
    public partial class DrawPaint : Form
    {
        public DrawPaint()
        {
            InitializeComponent();
        }

        int x0, y0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    Graphics X = pictureBox1.CreateGraphics();
                    Pen P = new Pen(colorDialog1.Color, int.Parse(txtB.Text));
                    X.DrawLine(P, x0, y0, e.X, e.Y);
                    x0 = e.X; y0 = e.Y;
                    //pictureBox1.Refresh();
                }
            }
            catch { MessageBox.Show("不是吧不是吧,連這個都要亂輸入是嗎"); }
        }

        private void DrawPaint_Load(object sender, EventArgs e)
        {
            //Graphics X = Graphics.FromImage(pictureBox1.Image);
            //X.Clear(Color.White);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor= colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0= e.X;
            y0= e.Y;
        }
    }
}
