using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Notepads : Form
    {
        public Notepads()
        {
            InitializeComponent();
        }



        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//正確選擇檔案之後按下確定鍵就可以執行
            {
                txt1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);//開啟的程式的文字
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)//正確選擇檔案之後按下確定鍵就可以執行
            {
                File.ReadAllText(saveFileDialog1.FileName, Encoding.Default);//開啟的程式的文字
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)//正確選擇檔案之後按下確定鍵就可以執行
                {
                    File.ReadAllText(saveFileDialog1.FileName, Encoding.Default);//開啟的程式的文字
                }
            }
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt1.SelectAll();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogX.ShowDialog();
            txt1.ForeColor = colorDialogX.Color;
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txt1.ForeColor= fontDialog1.Color;
        }
    }
}
