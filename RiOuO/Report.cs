using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Loan
{
    public partial class Report : Form
    {
        private Loan loan;

        public Report(string money, string year, string rate, string mon, string total)
        {
            InitializeComponent();
            txtReMoney.Text = money;
            txtReYear.Text = year;
            txtReYearRate.Text = rate;
            txtRePMTMon.Text = mon;
            txtReTotal.Text = total;
        }

        private void Report_Load(object sender, EventArgs e)
        {


        }
    }
}