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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }
        private bool CheckTextBox(TextBox textbox)
        {
            if (textbox.Text == "") return false;
            else
            {
                foreach (var t in textbox.Text.Trim())
                {
                    if (!char.IsNumber(t))
                    {
                        MessageBox.Show("Please enter a valid number!");
                        textbox.Text = "";
                        return false;
                    }
                }
            }
            
            return true;
        }
        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            if(CheckTextBox(textboxNum01) || CheckTextBox(textboxNum02))
            {
                //clean input result box
                textResult.Text = "";

                int num01 = int.Parse(textboxNum01.Text.Trim());
                int num02 = int.Parse(textboxNum02.Text.Trim());

                List<string> result = new List<string>
                {
                    "A! = " + GiaiThua(num01).ToString(),
                    "B! = " + GiaiThua(num02).ToString(),
                    "S1 = 1 + 2 + 3 + ... + " + num01.ToString() + " = " + BieuThuc01(num01).ToString(),
                    "S2 = 1 + 2 + 3 + ... + " + num02.ToString() + " = " + BieuThuc01(num02).ToString(),
                    "S3 = A^1 + A^2 + ... + A^" + num02.ToString() + " = " + BieuThuc02((double)num01, (double)num02).ToString()
                };

                foreach (string str in result)
                {
                    textResult.Text += str + "\r\n";
                }
            }
        }

        long GiaiThua(long n)
        {
            if (n == 1)
                return 1;
            return n * GiaiThua(n - 1);
        }
        long BieuThuc01(long A)
        {
            if (A == 1)
                return 1;
            return A + BieuThuc01(A-1);
        }
         double BieuThuc02(double A, double B)
        {
            double res= 0;
            for (int i = 1; i <= B; i++)
            {
                res += Math.Pow(A, i);
            }
            return res;
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            textboxNum01.Text = "";
            textboxNum02.Text = "";
            textResult.Text = "";
            

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
