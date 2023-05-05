using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Guess
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        int SaveMax = 100;
        int SaveMin = 0;
        public static int answer = 79;
      

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess Gu=new Guess();
            Gu.Show();
            Gu.Output = new Guess.GuessEvent(OuO);//宣告承接GuessEvent的委派事件
        }

        public void OuO(string Msg)//承接委派後要做的事情
        {
            try
            {
                int ReAnswer = (int.Parse(Msg));
                if (ReAnswer < answer)
                {
                    SaveMin = (int.Parse(Msg));
                    lab1To100.Text = $"太小囉\n介於{ReAnswer}和{SaveMax}之間";
                }
                else if (ReAnswer > answer)
                {
                    SaveMax = (int.Parse(Msg));
                    lab1To100.Text = $"太大囉\n介於{SaveMin}和{Msg}之間";
                }
                else { lab1To100.Text = "恭喜答對"; }
            }

            catch
            {
                MessageBox.Show("不要亂輸入= =");
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(answer.ToString());
        }
    }
}
