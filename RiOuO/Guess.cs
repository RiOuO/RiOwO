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
    public partial class Guess : Form
    {
        public delegate void GuessEvent(string Msg);//宣告委派delegate void為固定,GuessEvent(string Msg)自己取Msg為要傳過去的字串
        public GuessEvent Output;//傳遞資料的事件
        public Guess()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Output(txtAnswer.Text);//傳遞的資料
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
