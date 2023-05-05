using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Alarm
{
    public partial class Alam : Form
    {
        public Alam()
        {
            InitializeComponent();
        }
        string HH = "";
        string mm = "";
        string ss = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval= 1000;
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (labTime.Text == $"{HH}:{mm}:{ss}")
            {
                MessageBox.Show("時間到囉");
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            
            HH = txtHH.Text;
            mm = txtmm.Text;
            ss = txtss.Text;
        }
    }
}
