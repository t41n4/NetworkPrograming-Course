using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.M21._1_Lab05_Nhom9
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab05_Bai01 form = new Lab05_Bai01();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab05_Bai03 bai3 = new Lab05_Bai03();
            bai3.ShowDialog();
        }
    }
}
