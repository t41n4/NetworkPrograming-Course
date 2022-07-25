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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }
        private void CheckTextbox(TextBox textbox)
        {
            foreach (var t in textbox.Text.Trim())
            {
                if (!char.IsNumber(t))
                {
                    MessageBox.Show("Please enter a valid number!");
                    textbox.Text = "";
                    return;
                }
            }
            return;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(textBox1);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(textBox2);
        }

        private void Btn_LAB01_B01_CALC_Click(object sender, EventArgs e)
        {
            try
            {
                long num01, num02;
                num01 = long.Parse(textBox1.Text.Trim());
                num02 = long.Parse(textBox2.Text.Trim());
                textBox3.Text = (num01 + num02).ToString();
            }
            catch
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
            
        }

    


        private void BtnExit_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }

        private void Btn_RESET_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
