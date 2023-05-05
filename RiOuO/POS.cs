using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }
        int BeerCash = 0;
        int WineCash = 0;
        int ShochuCash = 0;
        int WihskyCash = 0;

        int BeerQua, WineQua, ShochuQua, WihskyQua=0;


        public void picBeer_Click(object sender, EventArgs e)
        {
            BeerCash = BeerCash + 120;
            labCash.Text ="NT$"+ Convert.ToString(BeerCash+WineCash+ShochuCash + WihskyCash);

            BeerQua = ++BeerQua;

            //如果list文字=尚未點餐,刪除list文字+新增項目
            //如果Cash=價格,新增項目
            //刪除指定項目+新增項目
           

            if (BeerQua+WineQua+ShochuQua+WihskyQua==1)                       //所有項目的第一次
            {
                listTo.Items.RemoveAt(listTo.FindString("尚未點餐"));
                listTo.Items.Add("啤酒Beer x" + BeerQua + ",NT$" + BeerCash);
            }

            else if (BeerCash==120)                                           //該項目的第一次
            {
                listTo.Items.Add("啤酒Beer x" + BeerQua + ",NT$" + BeerCash); //新增項目
            }

            else
            {
                listTo.Items.RemoveAt(listTo.FindString("啤酒Beer"));  //刪除
                listTo.Items.Add("啤酒Beer x" + BeerQua + ",NT$" + BeerCash); //新增項目
            }
        }

        public void picWine_Click(object sender, EventArgs e)
        {
            WineCash = WineCash + 320;
            labCash.Text = "NT$" + Convert.ToString(BeerCash + WineCash + ShochuCash+WihskyCash);

           WineQua = ++WineQua;


            if (BeerQua + WineQua + ShochuQua + WihskyQua == 1)               //所有項目的第一次
            {
                listTo.Items.RemoveAt(listTo.FindString("尚未點餐"));
                listTo.Items.Add("紅酒Wine x" + WineQua + ",NT$" + WineCash); //新增項目
            }

            else if (WineCash == 320)
            {
                listTo.Items.Add("紅酒Wine x" + WineQua + ",NT$" + WineCash); //新增項目
            }

            else
            {
                listTo.Items.RemoveAt(listTo.FindString("紅酒Wine"));  //刪除
                listTo.Items.Add("紅酒Wine x" + WineQua + ",NT$" + WineCash); //新增項目
            }

        }

        private void picShochu_Click(object sender, EventArgs e)
        {
            ShochuCash = ShochuCash + 180;
            labCash.Text = "NT$" + Convert.ToString(BeerCash + WineCash + ShochuCash+ WihskyCash);

            ShochuQua = ++ShochuQua;

            if (BeerQua + WineQua + ShochuQua + WihskyQua == 1)               //所有項目的第一次
            {
                listTo.Items.RemoveAt(listTo.FindString("尚未點餐"));
                listTo.Items.Add("燒酒Shochu x" + ShochuQua + ",NT$" + ShochuCash); //新增項目
            }

            else if (ShochuCash == 180)
            {
                listTo.Items.Add("燒酒Shochu x" + ShochuQua + ",NT$" + ShochuCash); //新增項目
            }

            else
            {
                listTo.Items.RemoveAt(listTo.FindString("燒酒Shochu"));  //刪除
                listTo.Items.Add("燒酒Shochu x" + ShochuQua + ",NT$" + ShochuCash); //新增項目
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listTo.Items.Clear();
            listTo.Items.Add("尚未點餐"); //新增項目
            labCash.Text = "NT$0";
            this.BeerQua = 0;
            this.WineQua = 0;
            this.ShochuQua = 0;
            this.WihskyQua = 0;
            this.BeerCash = 0;
            this.WineCash = 0;
            this.ShochuCash = 0;
            this.WihskyCash = 0;

        }

        private void picWihsky_Click(object sender, EventArgs e)
        {
            WihskyCash = WihskyCash + 350;
            labCash.Text = "NT$" + Convert.ToString(BeerCash + WineCash + ShochuCash+ WihskyCash);

            WihskyQua = ++WihskyQua;

            if (BeerQua + WineQua + ShochuQua + WihskyQua == 1)               //所有項目的第一次
            {
                listTo.Items.RemoveAt(listTo.FindString("尚未點餐"));
                listTo.Items.Add("威士忌Wihsky x" + WihskyQua + ",NT$" + WihskyCash); //新增項目
            }

            else if (WihskyCash == 350)
            {
                listTo.Items.Add("威士忌Wihsky x" + WihskyQua + ",NT$" + WihskyCash); //新增項目
            }

            else
            {
                listTo.Items.RemoveAt(listTo.FindString("威士忌Wihsky"));  //刪除
                listTo.Items.Add("威士忌Wihsky x" + WihskyQua + ",NT$" + WihskyCash); //新增項目
            }

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:"+labCash.Text+"元");
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            double Cardoff =   (BeerCash + WineCash + ShochuCash + WihskyCash)*0.9;
            MessageBox.Show("總金額:" + labCash.Text + "元"+"\n"+"折扣後金額:NT$"+Convert.ToString(Cardoff)+"元");
        }
    }
}