using System;
using System.Windows.Forms;

namespace NT106.M21._1_Lab04_Nhom9
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab04_Bai01 b1 = new Lab04_Bai01();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab04_Bai02 b2 = new Lab04_Bai02();
            b2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 form = new Lab04_Bai03();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab04_Bai04 bai4 = new Lab04_Bai04();
            bai4.ShowDialog();
        }

       
    }
}