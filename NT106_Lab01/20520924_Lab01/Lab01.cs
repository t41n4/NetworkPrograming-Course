using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20520924_Lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Lab01_Bai01_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 bai01 = new Lab01_Bai01();
            bai01.ShowDialog();
        }

        private void Btn_Lab01_Bai02_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 bai02 = new Lab01_Bai02();
            bai02.ShowDialog();
        }

        private void Btn_Lab01_Bai03_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 bai03 = new Lab01_Bai03();
            bai03.ShowDialog();
        }

        private void Btn_Lab01_Bai04_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 bai04 = new Lab01_Bai04();
            bai04.ShowDialog();
        }

        private void Btn_Lab01_Bai05_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 bai05 = new Lab01_Bai05();
            bai05.ShowDialog();
        }

        private void Btn_Lab01_Bai06_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 bai06 = new Lab01_Bai06();
            bai06.ShowDialog();
        }
    }
}
