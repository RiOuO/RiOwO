using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_StuGrade2
{
    public partial class StuGrade2 : Form
    {
        public StuGrade2()
        {
            InitializeComponent();
        }

        int i = 0;
        List<int> listlist = new List<int>();

        private void Lab_StuGrade2_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Visible = true;
                listView3.Visible = false;
                btnFinal.Enabled = true;
                i = listView1.Items.Count;
                int StuTotal = int.Parse(txtCn.Text) + int.Parse(txtEn.Text) + int.Parse(txtMath.Text);
                List<string> list = new List<string>() { txtCn.Text, txtEn.Text, txtMath.Text };
                string StuMin = list.Min();
                string StuMax = list.Max();
                int StuAverage = StuTotal / 3;
                listView1.Items.Add(Convert.ToString(txtName.Text));
                listView1.Items[i].SubItems.Add(Convert.ToString(txtCn.Text));
                listView1.Items[i].SubItems.Add(Convert.ToString(txtEn.Text));
                listView1.Items[i].SubItems.Add(Convert.ToString(txtMath.Text));
                listView1.Items[i].SubItems.Add(Convert.ToString(StuTotal));
                listView1.Items[i].SubItems.Add(Convert.ToString(StuAverage));
                listView1.Items[i].SubItems.Add(StuMin);
                listView1.Items[i].SubItems.Add(StuMax);
                i = i++;
                //listView1.Items.Insert
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Visible = true;
                listView3.Visible = false;
                btnFinal.Enabled = true;
                int StuTotal = int.Parse(txtCn.Text) + int.Parse(txtEn.Text) + int.Parse(txtMath.Text);
                List<string> list = new List<string>() { txtCn.Text, txtEn.Text, txtMath.Text };
                string StuMin = list.Min();
                string StuMax = list.Max();
                int StuAverage = StuTotal / 3;
                listView1.Items.Insert(0, Convert.ToString(txtName.Text));
                listView1.Items[0].SubItems.Add(Convert.ToString(txtCn.Text));
                listView1.Items[0].SubItems.Add(Convert.ToString(txtEn.Text));
                listView1.Items[0].SubItems.Add(Convert.ToString(txtMath.Text));
                listView1.Items[0].SubItems.Add(Convert.ToString(StuTotal));
                listView1.Items[0].SubItems.Add(Convert.ToString(StuAverage));
                listView1.Items[0].SubItems.Add(StuMin);
                listView1.Items[0].SubItems.Add(StuMax);
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
            listView1.Visible = true;
            i =listView1.Items.Count;
            if (i == 0)
            {

            }
            else
            {
                listView1.Items.RemoveAt(0);
            }
        }

        private void btnAllDel_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            btnDel.Enabled = true;
            btnAddStudent.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            try
            {
                listView3.Items.Clear();
                listView3.Visible = true;
                listView1.Visible = false;
                int RangeMin = int.Parse(txtIndex1.Text);
                int RangeMax = int.Parse(txtIndex2.Text);
                for (int x = 0; x < listView1.Items.Count; x++)
                {
                    int ItemsText = int.Parse(listView1.Items[x].SubItems[1].Text);
                    if (ItemsText >= RangeMin && ItemsText <= RangeMax)
                    {
                        int Cnnn = int.Parse(listView1.Items[x].SubItems[1].Text);
                        int Ennn = int.Parse(listView1.Items[x].SubItems[2].Text);
                        int Mathhh = int.Parse(listView1.Items[x].SubItems[3].Text);
                        int total = Cnnn + Ennn + Mathhh;
                        int average = total / 3;
                        List<int> list = new List<int>() { Cnnn, Ennn, Mathhh };
                        int minnn = list.Min();
                        int maxnn = list.Max();
                        listView3.Items.Add(listView1.Items[x].Text);
                        listView3.Items[x].SubItems.Add(listView1.Items[x].SubItems[1].Text);
                        listView3.Items[x].SubItems.Add(listView1.Items[x].SubItems[2].Text);
                        listView3.Items[x].SubItems.Add(listView1.Items[x].SubItems[3].Text);
                        listView3.Items[x].SubItems.Add(Convert.ToString(total));
                        listView3.Items[x].SubItems.Add(Convert.ToString(average));
                        listView3.Items[x].SubItems.Add(Convert.ToString(minnn));
                        listView3.Items[x].SubItems.Add(Convert.ToString(maxnn));
                    }
                }
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
            //getrange
            //找出符合篩選的列後全部新增上去
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                btnDel.Enabled = false;
                btnAddStudent.Enabled = false;
                btnFinal.Enabled = false;
                btnInsert.Enabled = false;

                int AllSubItem1 = 0;
                int AllSubItem2 = 0;
                int AllSubItem3 = 0;
                int Average1 = 0;
                int Average2 = 0;
                int Average3 = 0;
                int ItemCount = listView1.Items.Count;
                int Max = 0;
                List<int> RankCn = new List<int>() { };
                List<int> RankEn = new List<int>() { };
                List<int> RankMath = new List<int>() { };

                for (int f = 0; f < ItemCount; f++)                                   //用迴圈抓出指定欄的數值總和
                {
                    AllSubItem1 += int.Parse(listView1.Items[f].SubItems[1].Text);
                    AllSubItem2 += int.Parse(listView1.Items[f].SubItems[2].Text);
                    AllSubItem3 += int.Parse(listView1.Items[f].SubItems[3].Text);
                    Average1 = AllSubItem1 / ItemCount;
                    Average2 = AllSubItem2 / ItemCount;
                    Average3 = AllSubItem3 / ItemCount;

                    RankCn.Add(int.Parse(listView1.Items[f].SubItems[1].Text));
                    RankEn.Add(int.Parse(listView1.Items[f].SubItems[2].Text));
                    RankMath.Add(int.Parse(listView1.Items[f].SubItems[3].Text));
                }

                int FinalCnMax = RankCn.Max();
                int FinalCnMin = RankCn.Min();
                int FinalEnMax = RankEn.Max();
                int FinalEnMin = RankEn.Min();
                int FinalMathMax = RankMath.Max();
                int FinalMathMin = RankMath.Min();

                listView2.Items.Clear();
                listView2.Items.Add("總分");
                listView2.Items[0].SubItems.Add($"{AllSubItem1}");
                listView2.Items[0].SubItems.Add($"{AllSubItem2}");
                listView2.Items[0].SubItems.Add($"{AllSubItem3}");
                listView2.Items.Add("平均");
                listView2.Items[1].SubItems.Add(Average1.ToString("f2"));
                listView2.Items[1].SubItems.Add(Average2.ToString("f2"));
                listView2.Items[1].SubItems.Add(Average3.ToString("f2"));
                listView2.Items.Add("最高分");
                listView2.Items[2].SubItems.Add($"{FinalCnMax}");
                listView2.Items[2].SubItems.Add($"{FinalEnMax}");
                listView2.Items[2].SubItems.Add($"{FinalMathMax}");
                listView2.Items.Add("最低分");
                listView2.Items[3].SubItems.Add($"{FinalCnMin}");
                listView2.Items[3].SubItems.Add($"{FinalEnMin}");
                listView2.Items[3].SubItems.Add($"{FinalMathMin}");
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }
    }
}
