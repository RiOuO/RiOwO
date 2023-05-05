using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Method
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            try
            {
                int Number = int.Parse(txtNumber.Text);
                if (Number == 1)
                {
                    labResultOutPut.Text = "數入數字" + Number + "為奇數";
                }
                else if (Number % 2 == 0)
                {
                    labResultOutPut.Text = "數入數字" + Number + "為偶數";
                }
                else
                {
                    labResultOutPut.Text = "數入數字" + Number + "為奇數";
                }
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnArr_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string arrMax = Convert.ToString(arr.Max());
            string arrMin = Convert.ToString(arr.Min());
            labResultOutPut.Text = $"陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為 {arrMax}\n最小值為 {arrMin}";
        }

        
        private void btnArrEven_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int arrEven = 0;
            int arrOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2== 0)   //宣告偶數、奇數變數來儲存,用除2後有沒有餘數來評斷是不是偶數,再給指定的變數+1來統計
                {
                    arrEven++;
                }
                else
                {
                    arrOdd++;
                }
            }
            labResultOutPut.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共 {arrOdd}\n偶數共 {arrEven}";
        }

        private void btnArrTotal_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int ArrTotal = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                ArrTotal += arr[i];
            }
            labResultOutPut.Text = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n加總為 {ArrTotal}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = new string[6] { "Emma", "Allen", "MinChiKao", "Ariel", "HanTing", "Deborah " };
            int[] strLong = new int[6] ;
            for(int i = 0; i < str.Length; i++)
            {
                string txt=Convert.ToString(str.GetValue(i));    //取出該輪字串的值給變數txt
                strLong[i] = txt.Length;                         //宣告數列strLong[i]=txt值的長度
            }
            Array.Sort(strLong, str);                            //遞增排序,讓數列str的排序跟strLong一樣
            string Output = str[str.Length-1];                   //取出數列str項目數-1(等於最後一個索引)的值,就是最長的字串
            labResultOutPut.Text = $"陣列str[Emma, Allen, MinChiKao,Ariel, HanTing, Deborah]\n最長的名字為 {Output}";
        }

        private void btnStrEande_Click(object sender, EventArgs e)
        {
            int Final = 0;
            string[] str = new string[] { "Emma", "Allen", "MinChiKao", "Ariel", "HanTing", "Deborah " };
            for (int i = 0; i < str.Length; i++)
            {
                string txt = Convert.ToString(str.GetValue(i));
                bool Output1 = txt.Contains("E");
                bool Output2 = txt.Contains("e");
                if (Output1 || Output2==true)
                {
                    Final++;  //統計數量用的變數,如果符合條件就+1,作為輸出統計值的依據
                }
            }
            labResultOutPut.Text = $"陣列str[Emma, Allen, MinChiKao,Ariel, HanTing, Deborah]\n有E,e的名字共 {Final}個";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResultOutPut.Text = "結果";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labResultOutPut.Text = "";
            int[,] two = new int[5, 7];
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    two[y, x] = 0;                 //初始化所有數值為0
                }
            }
             for (int y = 0; y < 5; y++)
             {
                    for (int x = 0; x < 7; x++)    //按照需要的列或欄去改值
                    {
                    two[y, 0] = 1;
                    two[y, 6] = 1;
                    two[0, x] = 1;
                    two[4, x] = 1;
                    labResultOutPut.Text += $"{two.GetValue(y, x)}";
                    }
                labResultOutPut.Text += "\n";
             }
        }

        private void btn1010_Click(object sender, EventArgs e)
        {
            int xx = 0;
            labResultOutPut.Text = "";
            int[,] two = new int[5, 7];
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    two[y, x] = 0;
                }
            }
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (xx == 0)
                    {
                        two[y, x] = 1;
                        xx = 1;
                        labResultOutPut.Text += $"{two.GetValue(y, x)}";    //給予一個無關的數來作為評斷依據(1 or 0),更改數列的值
                    }
                    else if (xx == 1)
                    {
                        two[y, x] = 0;
                        xx = 0;
                        labResultOutPut.Text += $"{two.GetValue(y, x)}";
                    }  
                }
                labResultOutPut.Text += "\n";
            }
        }

        private void btnloto_Click(object sender, EventArgs e)
        {
            Random Ram= new Random();
            List<int> list = new List<int>();
            do
            {
                int number = Ram.Next(1, 50);
                int xx = list.IndexOf(number);
                if (xx < 0)                    //如果IndexOf回傳的為-1(找不到相同的)就執行,執行到while (list.Count < 6)第6次為止
                {
                    list.Add(number);
                }
            } 
            while (list.Count < 6);
            labResultOutPut.Text = $"樂透號碼：{list[0]} , {list[1]} , {list[2]} , {list[3]} , {list[4]} , {list[5]}";
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            try
            {
                labResultOutPut.Text = "";
                int tree = int.Parse(txtTree.Text);//回傳數字為多少就執行幾次迴圈
                int k = 0;
                if (k < tree)
                {
                    do
                    {
                        ++k;
                        for (int i = 0; i < k; i++)
                        {
                            labResultOutPut.Text += "*";
                        }
                        labResultOutPut.Text += "\n";
                    }
                    while (k < tree);
                }
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btn100To2_Click(object sender, EventArgs e)
        {
            int To = 100;
            string output = Convert.ToString(To, 2);//這種寫法就是把10整數改成2進位制
            labResultOutPut.Text = "";
            labResultOutPut.Text += output;
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            labResultOutPut.Text = "";
            string[,] Nine = new string[8, 9];
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Nine[y, x] = $"{y + 2}x{x + 1}={(y + 2) * (x + 1)}|";//照著邏輯去填
                    labResultOutPut.Text += Nine[y, x];
                }
                labResultOutPut.Text += "\n";
            }

        }

        private void btnFDW_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtFrom.Text);//1
                int y = int.Parse(txtTo.Text);//4
                int z = int.Parse(txtStep.Text);//2
                int XXXX = 0;
                int cc = x;
                for (int i = x; i <= y; i += z)
                {
                    XXXX += x;
                    x = x + z;
                }
                labResultOutPut.Text = $"{x} 到 {y} 加總為 {XXXX}";
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtFrom.Text);//1
                int y = int.Parse(txtTo.Text);//4
                int z = int.Parse(txtStep.Text);//2
                int XXXX = 0;
                int cc = x;
                while (x <= y)
                {
                    XXXX += x;
                    x = x + z;
                }
                labResultOutPut.Text = $"{x} 到 {y} 加總為 {XXXX}";
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtFrom.Text);//1
                int y = int.Parse(txtTo.Text);//4
                int z = int.Parse(txtStep.Text);//2
                int XXXX = 0;
                int cc = x;
                do
                {
                    XXXX += x;
                    x = x + z;
                } while (x <= y);
                labResultOutPut.Text = $"{x} 到 {y} 加總為 {XXXX}";
            }
            catch { MessageBox.Show("不要亂輸入= ="); }
        }
    }
    }

