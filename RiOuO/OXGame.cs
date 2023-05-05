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
    public partial class OXGame : Form
    {
        public OXGame()
        {
            InitializeComponent();
        }
        int xx = 0;
       

        void Test(Button button)
        {
            if (xx == 0)
            {
                button.Text = "O";
                xx = 1;
            }
            else
            {
                button.Text = "X";
                xx = 0;
            }
            string BT1 = button1.Text;
            string BT2 = button2.Text;
            string BT3 = button3.Text;
            string BT4 = button4.Text;
            string BT5 = button5.Text;
            string BT6 = button6.Text;
            string BT7 = button7.Text;
            string BT8 = button8.Text;
            string BT9 = button9.Text;
            if (BT1==BT2&&BT1==BT3 && BT1!="")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利");
                }
                else
                { MessageBox.Show("X勝利"); }
            }
            else if (BT4 == BT5 && BT4 == BT6 && BT4 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利" ); }
            }
            else if (BT7 == BT8&& BT7 == BT9 && BT7 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利"); }
            }
            else if (BT1 == BT4 && BT4 == BT7 && BT4 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利" ); }
            }
            else if (BT2 == BT5 && BT5 == BT8 && BT2 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利" ); }
            }
            else if (BT3 == BT6 && BT6 == BT9 && BT3 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利" ); }
            }
            else if (BT1 == BT5 && BT5 == BT9 && BT1 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利" ); }
            }
            else if (BT3 == BT5 && BT5 == BT7 && BT3 != "")
            {
                if (xx == 1)
                {
                    MessageBox.Show("O勝利" );
                }
                else
                { MessageBox.Show("X勝利" ); }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Test(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Test(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Test(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Test(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Test(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Test(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Test(button9);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            xx = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}


