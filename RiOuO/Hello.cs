using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Hello
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            try
            {
                string NameCn = txtCnName.Text;
                string NameEn = txtEnName.Text;
                string Sex = txtSex.Text;
                string Con = txtCon.Text;
                MessageBox.Show("Hello!" + NameCn + "\n英文姓名:" + NameEn + "\n性別:" + Sex + "\n星座:" + Con);
            }
            catch { MessageBox.Show("人家的第一支程式你也要這樣ㄇ"); }
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            try
            {
                string NameCn = txtCnName.Text;
                string NameEn = txtEnName.Text;
                string Sex = txtSex.Text;
                string Con = txtCon.Text;
                MessageBox.Show("Hi!" + NameCn + "\n英文姓名:" + NameEn + "\n性別:" + Sex + "\n星座:" + Con);
            }
            catch { MessageBox.Show("人家的第一支程式你也要這樣ㄇ"); } 
        }
    }
}
