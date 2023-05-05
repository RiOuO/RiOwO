using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_StuStu
{
    public partial class Frm_StuStu : Form
    {
        public Frm_StuStu()
        {
            InitializeComponent();
        }

        string NameN;
        int Cn, En, Math;

        private void btnLook_Click(object sender, EventArgs e)
        {
            try
            {
                txt1.Text = "姓名：" + NameN + Environment.NewLine + "國文：" + Cn + "分" + Environment.NewLine + "英文：" + En + "分" + Environment.NewLine + "數學：" + Math + "分";
            }
            catch { MessageBox.Show("不要亂輸入= ="); } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.NameN = txtName.Text;
                this.Cn = int.Parse(txtCn.Text);
                this.En = int.Parse(txtEn.Text);
                this.Math = int.Parse(txtMath.Text);
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            try
            {
                //讀取儲存的成績並且找出最大最小值
                score CnScore;
                score EnScore;
                score MathScore;
                CnScore.Cnn = Cn;
                CnScore.CnnN = "國文";
                EnScore.Enn = En;
                EnScore.EnnN = "英文";
                MathScore.Mathh = Math;
                MathScore.MathhH = "數學";

                int[] MaxMin = { CnScore.Cnn, EnScore.Enn, MathScore.Mathh };
                int Max = MaxMin.Max();
                txt2.Text = "";

                if (Max == CnScore.Cnn)
                {
                    txt2.Text += "最高科目成績為：國文" + Max + "分";
                }
                else if (Max == EnScore.Enn)
                {
                    txt2.Text += "最高科目成績為：英文" + Max + "分";
                }
                else
                {
                    txt2.Text += "最高科目成績為：數學" + Max + "分";
                }

                int Min = MaxMin.Min();

                if (Min == CnScore.Cnn)
                {
                    txt2.Text += Environment.NewLine + "最低科目成績為：國文" + Min + "分";
                }
                else if (Min == EnScore.Enn)
                {
                    txt2.Text += Environment.NewLine + "最低科目成績為：英文" + Min + "分";
                }
                else
                {
                    txt2.Text += Environment.NewLine + "最低科目成績為：數學" + Min + "分";
                }
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        public struct score
        {
            public int Cnn,Enn,Mathh;
            public string CnnN, EnnN, MathhH;
        }

     }
    }

