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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_READ_Click(object sender, EventArgs e)
        {
           
            switch (textInput.Text.Trim())
            {
                case "1":
                    {
                        textOutput.Text = "Một";
                        break;
                    }
                case "2":
                    {
                        textOutput.Text = "Hai";
                        break;
                    }
                case "3":
                    {
                        textOutput.Text = "Ba";
                        break;
                    }
                case "4":
                    {
                        textOutput.Text = "Bốn";
                        break;
                    }
                case "5":
                    {
                        textOutput.Text = "Năm";
                        break;
                    }
                case "6":
                    {
                        textOutput.Text = "Sáu";
                        break;

                    }
                case "7":
                    {
                        textOutput.Text = "Bảy";
                        break;
                    }
                case "8":
                    {
                        textOutput.Text = "Tám";
                        break;
                    }
                case "9":
                    {
                        textOutput.Text = "Chín";
                        break;
                    }
               
                default:
                    {
                        MessageBox.Show("Nhập số nguyên từ 0-9");
                        textOutput.Text = "";
                        break; 
                        
                    }
                    
            }
        }

        private void Btn_RESET_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            textInput.Text = "";
           
           
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }
}
