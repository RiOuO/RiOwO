using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Loan
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        public void btnMonPMT_Click(object sender, EventArgs e)
        {
            try
            {
                double Money, Year, Rate, First, PMTRate, PMTMon;
                Money = Convert.ToDouble(txtMoney.Text);
                Year = Convert.ToDouble(txtYear.Text);
                Rate = Convert.ToDouble(txtYearRate.Text) / 100;
                First = Convert.ToDouble(txtFirst.Text);

                //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
                PMTRate = (Math.Pow(1 + (Rate / 12), (Year * 12)) * (Rate / 12)) / (Math.Pow(1 + (Rate / 12), (Year * 12)) - 1);
                PMTMon = PMTRate * Money;
                MessageBox.Show("月付額:" + PMTMon.ToString("N0") + "元");
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        public void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                double Money, Year, Rate, First, PMTRate, PMTMon, Total;
                Money = Convert.ToDouble(txtMoney.Text);
                Year = Convert.ToDouble(txtYear.Text);
                Rate = Convert.ToDouble(txtYearRate.Text) / 100;
                First = Convert.ToDouble(txtFirst.Text);

                //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
                PMTRate = (Math.Pow(1 + (Rate / 12), (Year * 12)) * (Rate / 12)) / (Math.Pow(1 + (Rate / 12), (Year * 12)) - 1);
                PMTMon = PMTRate * Money;
                Total = PMTMon * Year * 12;
                MessageBox.Show("總付額:" + Total.ToString("N0") + ("元"));
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        public void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                double Money, Year, Rate, First, PMTRate, PMTMon, Total;
                Money = Convert.ToDouble(txtMoney.Text);
                Year = Convert.ToDouble(txtYear.Text);
                Rate = Convert.ToDouble(txtYearRate.Text) / 100;
                First = Convert.ToDouble(txtFirst.Text);

                //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
                PMTRate = (Math.Pow(1 + (Rate / 12), (Year * 12)) * (Rate / 12)) / (Math.Pow(1 + (Rate / 12), (Year * 12)) - 1);
                PMTMon = PMTRate * Money;
                Total = PMTMon * Year * 12;

                Report re = new Report(txtMoney.Text, txtYear.Text, txtYearRate.Text, PMTMon.ToString("F0"), Total.ToString("F0"));
                re.Show();
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }
    }
}
