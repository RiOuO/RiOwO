using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Lab_PictureViewer
{
    public partial class Pic1 : Form
    {
        public Pic1()
        {
            InitializeComponent();
        }
        //public delegate void PictureShow();
        //開啟檔案的時候讀取指定資料夾的檔案名稱
        //加進陣列
        private void Pic1_Load(object sender, EventArgs e)
        {
            string path = @"Pictures";
            string[] aa=Directory.GetFiles(path);
            int x = 30;
            int y=20;
            foreach (string i in aa)
            {
                PictureBox pb = new PictureBox();
                if (x > this.ClientSize.Width-100)
                {
                    x = 30;
                    y += 120;
                    pb.Name = i;
                    pb.Location = new Point(x, y);
                    pb.Size = new Size(100, 100);
                    pb.Image = Image.FromFile(i);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    panel1.Controls.Add(pb);
                    pb.Click += new EventHandler(this.pb_Click);
                }
                else
                {
                    pb.Name = i;
                    pb.Location = new Point(x, y);
                    pb.Size = new Size(100, 100);
                    pb.Image = Image.FromFile(i);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    panel1.Controls.Add(pb);
                    pb.Click += new EventHandler(this.pb_Click);
                    x += 120;
                }
            }
        }
        private void pb_Click(object sender, EventArgs e)
        {  
            PictureBox pb=(PictureBox)sender;
            Picture pb1=new Picture(pb.Image);
            pb1.Show();

        }
    }
}
