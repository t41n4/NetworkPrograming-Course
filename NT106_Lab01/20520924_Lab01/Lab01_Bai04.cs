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
    
    public partial class Lab01_Bai04 : Form
    {
        double tyGia =0 ;
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void Lab01_Bai04_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("USD");
            comboBox1.Items.Add("EUR");
            comboBox1.Items.Add("GBP");
            comboBox1.Items.Add("SGD");
            comboBox1.Items.Add("JPY");
        }
        private bool Check_Textbox_Double(TextBox textBox)
        {
            if (!double.TryParse(textBox.Text.Trim(), out _))
            {
                MessageBox.Show("Please enter a valid number!");
                textBox.Text = "";
                return false;
            }
            return true;
        }
        private void Bnt_Doi_Click(object sender, EventArgs e)
        {
           if(Check_Textbox_Double(textInput)&&tyGia != 0)
            {
                textResult.Text = (tyGia * double.Parse(textInput.Text.Trim())).ToString()+" VND";
            }
            else
            {
                MessageBox.Show("xin chọn loại tiền tệ");
                return;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "USD":
                    {
                        tyGia = 22772;
                        textTyGia.Text = "1 USD = " + tyGia.ToString() + " VND";
                        break;
                    }
                case "EUR":
                    {
                        tyGia = 28132;
                        textTyGia.Text = "1 EUR = " + tyGia.ToString() + " VND";

                        break;
                    }
                case "GBP":
                    {
                        tyGia = 31538;
                        textTyGia.Text = "1 GBP = " + tyGia.ToString() + " VND";

                        break;
                    }
                case "SGD":
                    {

                        tyGia = 17286;
                        textTyGia.Text ="1 SGD = " + tyGia.ToString() + " VND";
                        break;
                    }
                case "JPY":
                    {
                        tyGia = 214;
                        textTyGia.Text = "1 JPY = " + tyGia.ToString() + " VND";
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Xin Hãy chọn loại tiền tệ muốn quy đổi!");
                        break;
                    }
            }

         }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_RESET_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            textResult.Text = "";
            comboBox1.Text = "";
            textTyGia.Text = "";
          
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
