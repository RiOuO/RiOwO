using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Lab_StuGrade
{
    public partial class StuGrade : Form
    {
        public StuGrade()
        {
            InitializeComponent();
        }

        int f = 0;

        public struct Score
        {
            public string SName;
            public int Cn, En, Math, Total, Average, Min, Max;
        }

        public void btnAddStudentData_Click(object sender, EventArgs e)
        {
            try
            {
                Score Studata;
                Studata.SName = txtName.Text;
                Studata.Cn = int.Parse(txtCn.Text);
                Studata.En = int.Parse(txtEn.Text);
                Studata.Math = int.Parse(txtMath.Text);
                Studata.Total = Studata.Cn + Studata.En + Studata.Math;
                Studata.Average = Studata.Total / 3;

                List<int> ScoreList = new List<int>() { Studata.Cn, Studata.En, Studata.Math };//用List來取最大最小
                Studata.Min = ScoreList.Min();
                Studata.Max = ScoreList.Max();

                listView1.Items.Add(Studata.SName);

                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.Cn));
                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.En));
                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.Math));
                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.Total));
                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.Average));
                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.Min));
                listView1.Items[f].SubItems.Add(Convert.ToString(Studata.Max));
                f = f + 1;

                btnStatistics.Enabled = true;
            }

            catch
            {
                MessageBox.Show("請輸入完整!");
            }
            
            
        }

        public void btnRandomSave_Click(object sender, EventArgs e)
        {
            try
            {
                Random rdm = new Random();

                listView1.Items.Add(Convert.ToString(listView1.Items.Count + 1));//新增姓名欄,數字為目前項目數+1
                int RanCn, RanEn, RanMath, Total, RanAverage, RanMin, RanMax;              //製作亂數,計算各欄位值
                RanCn = rdm.Next(1, 101);
                RanEn = rdm.Next(1, 101);
                RanMath = rdm.Next(1, 101);
                Total = RanCn + RanEn + RanMath;
                RanAverage = Total / 3;
                List<int> RanT = new List<int>() { RanCn, RanEn, RanMath };       //List計算最大最小
                RanMin = RanT.Min();
                RanMax = RanT.Max();
                //Average=RanT.Average();
                listView1.Items[f].SubItems.Add($"{RanCn}");                    //新增項目
                listView1.Items[f].SubItems.Add($"{RanEn}");
                listView1.Items[f].SubItems.Add($"{RanMath}");
                listView1.Items[f].SubItems.Add($"{Total}");
                listView1.Items[f].SubItems.Add($"{RanAverage}");
                listView1.Items[f].SubItems.Add($"{RanMin}");
                listView1.Items[f].SubItems.Add($"{RanMax}");
                f = f + 1;

                btnStatistics.Enabled = true;
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            btnStatistics.Enabled = false;
            btnAddStudentData.Enabled = true;
            btnRandomSave.Enabled = true;
            btnRando20.Enabled = true;
            f = 0;
            //btnStatistics.Click += btnStatistics_Click;
        }

        

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            try
            {
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

                for (int i = 0; i < ItemCount; i++)                                   //用迴圈抓出指定欄的數值總和
                {
                    AllSubItem1 += int.Parse(listView1.Items[i].SubItems[1].Text);
                    AllSubItem2 += int.Parse(listView1.Items[i].SubItems[2].Text);
                    AllSubItem3 += int.Parse(listView1.Items[i].SubItems[3].Text);
                    Average1 = AllSubItem1 / ItemCount;
                    Average2 = AllSubItem2 / ItemCount;
                    Average3 = AllSubItem3 / ItemCount;

                    RankCn.Add(int.Parse(listView1.Items[i].SubItems[1].Text));
                    RankEn.Add(int.Parse(listView1.Items[i].SubItems[2].Text));
                    RankMath.Add(int.Parse(listView1.Items[i].SubItems[3].Text));
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

                btnAddStudentData.Enabled = false;
                btnRandomSave.Enabled = false;
                btnRando20.Enabled = false;
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnRando20_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    listView1.Items.Add(Convert.ToString(listView1.Items.Count + 1));//新增姓名欄,數字為目前項目數+1
                    int RanCn, RanEn, RanMath, Total, RanAverage, RanMin, RanMax;              //製作亂數,計算各欄位值
                    RanCn = RanDDD.rdm.Next(1, 101);
                    RanEn = RanDDD.rdm.Next(1, 101);
                    RanMath = RanDDD.rdm.Next(1, 101);
                    Total = RanCn + RanEn + RanMath;
                    RanAverage = Total / 3;
                    List<int> RanT = new List<int>() { RanCn, RanEn, RanMath };       //List計算最大最小
                    RanMin = RanT.Min();
                    RanMax = RanT.Max();
                    //Average=RanT.Average();
                    listView1.Items[f].SubItems.Add($"{RanCn}");                    //新增項目
                    listView1.Items[f].SubItems.Add($"{RanEn}");
                    listView1.Items[f].SubItems.Add($"{RanMath}");
                    listView1.Items[f].SubItems.Add($"{Total}");
                    listView1.Items[f].SubItems.Add($"{RanAverage}");
                    listView1.Items[f].SubItems.Add($"{RanMin}");
                    listView1.Items[f].SubItems.Add($"{RanMax}");
                    f = f + 1;
                }
                btnStatistics.Enabled = true;
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        public static class RanDDD
        {
            public static Random rdm= new Random();
        }
    }
}
