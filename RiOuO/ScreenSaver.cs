using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_OXGame
{
    public partial class ScreenSaver : Form

    {
        public ScreenSaver()
        {
            InitializeComponent();
        }
        int speedX = 50;//設定X和Y移動速度
        int speedY = 20;

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Neko.Left += speedX;//每0.1 秒貓貓往右50像素
            Neko.Top += speedY;//每0.1 秒貓貓往下20像素

            if (Neko.Right > this.ClientSize.Width||Neko.Right-200<0)//持續往下至邊界後轉換speedX的正負值,右的素質小於0的時候也轉換一次,只有到兩個臨界值才會動到一次if判斷式
            {
                speedX = -speedX;
            }
            if (Neko.Top +200> this.ClientSize.Height || Neko.Top  < 0)
            {
                speedY = -speedY;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();//讓timer從程式執行時就開始運作
        }

        private void ScreenSaver_Move(object sender, EventArgs e)
        {
            
        }
    }
}
