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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }
        private bool Check_Textbox_Double(TextBox textBox)
        {
            if (!double.TryParse(textBox.Text.Trim(), out _ ))
                {                  
                    MessageBox.Show("Please enter a valid number!");
                    textBox.Text = "";
                    return false;
                }
            return true;
        }
       
        private void Btn_START_Click(object sender, EventArgs e)
        {
           if(TxbNum01.Text == "" || TxbNum02.Text == "" ||  TxbNum03.Text == "")
            {
                MessageBox.Show("Chưa có dữ liệu!");
                return;
            }
           
           else if ( Check_Textbox_Double(TxbNum01) && Check_Textbox_Double(TxbNum02) && Check_Textbox_Double(TxbNum03)) 
            {
                double num01, num02, num03;
                num01 = double.Parse(TxbNum01.Text.Trim());
                num02 = double.Parse(TxbNum02.Text.Trim());
                num03 = double.Parse(TxbNum03.Text.Trim());
                TxbMax.Text = Math.Max(Math.Max(num01, num02),num03).ToString();
                TxbMin.Text = Math.Min(Math.Min(num01, num02), num03).ToString();
            }                         
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }

        private void BtnRESET_Click(object sender, EventArgs e)
        {
            TxbNum01.Text = "";
            TxbNum02.Text = "";
            TxbNum03.Text = "";
            TxbMax.Text = "";
            TxbMin.Text = "";

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
