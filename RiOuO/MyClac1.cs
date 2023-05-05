using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClac
{
    public partial class MyClac1 : Form
    {
        public MyClac1()
        {
            InitializeComponent();
        }

        private void btnCha_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtNumber1.Text, out double num1))
                {
                    if (double.TryParse(txtNumber2.Text, out double num2))
                    {
                        double Result = num1 + num2;
                        txtResult.Text = Convert.ToString(Result);
                    }
                    else
                        MessageBox.Show("請輸入數值");
                }
                else
                    MessageBox.Show("請輸入數值");
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnZen_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtNumber1.Text, out double num1))
                {
                    if (double.TryParse(txtNumber2.Text, out double num2))
                    {
                        double Result = num1 - num2;
                        txtResult.Text = Convert.ToString(Result);
                    }
                    else
                        MessageBox.Show("請輸入數值");
                }
                else
                    MessageBox.Show("請輸入數值");
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtNumber1.Text, out double num1))
                {
                    if (double.TryParse(txtNumber2.Text, out double num2))
                    {
                        double Result = num1 * num2;
                        txtResult.Text = Convert.ToString(Result);
                    }
                    else
                        MessageBox.Show("請輸入數值");
                }
                else
                    MessageBox.Show("請輸入數值");
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtNumber1.Text, out double num1))
                {
                    if (double.TryParse(txtNumber2.Text, out double num2))
                    {
                        double Result = num1 / num2;
                        txtResult.Text = Convert.ToString(Result);
                    }
                    else
                        MessageBox.Show("請輸入數值");
                }
                else
                    MessageBox.Show("請輸入數值");
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }
    }
}
