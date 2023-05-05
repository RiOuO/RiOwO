using Lab_Alarm;
using Lab_DrawPaint;
using Lab_Guess;
using Lab_Hello;
using Lab_Loan;
using Lab_Method;
using Lab_OXGame;
using Lab_PictureViewer;
using Lab_StuGrade;
using Lab_StuGrade2;
using Lab_StuStu;
using MyClac;
using Notepad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace RiOuO
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        public Form FO = null;

        public object F0 { get; private set; }

        public void OPEN(Form chOP)
        {
            splitContainer2.Panel2.Controls.Clear();
           chOP.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(chOP);
            chOP.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            OPEN(new Loan());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            OPEN(new POS());
        }

        private void btnSSF_Click(object sender, EventArgs e)
        {
            OPEN(new Frm_StuStu());
        }

        private void btnSG_Click(object sender, EventArgs e)
        {
            OPEN(new StuGrade());
        }

        private void btnSG2_Click(object sender, EventArgs e)
        {
            OPEN(new StuGrade2());
        }

        private void btnFDW_Click(object sender, EventArgs e)
        {
            OPEN(new Method());
        }

        private void btnOXGame_Click(object sender, EventArgs e)
        {
            OPEN(new OXGame());
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver sc = new ScreenSaver();
            splitContainer2.Panel2.Controls.Clear();
            sc.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            OPEN(new Notepads());
        }

        private void btnDrawPaint_Click(object sender, EventArgs e)
        {
            OPEN(new DrawPaint());
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            OPEN(new Pic1());
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            OPEN(new test());
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            OPEN(new Alam());
        }

        private void splitContainer2_Panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blackpink in Your Area <3,",">w<");
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            OPEN(new Hello());
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            OPEN(new MyClac1());
        }

        private void btnBlink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blackpink in Your Area <3,", ">w<");
        }
    }
}
