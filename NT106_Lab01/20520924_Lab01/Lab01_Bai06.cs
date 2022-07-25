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
    public partial class Lab01_Bai06 : Form
    {

        public Lab01_Bai06()
        {
            InitializeComponent();
        }
        private float[] listDiem;
        private float[] XuLiInput(string str)
        {
            float[] res = { };
            try
            {
                if (str != "")
                {
                    res = Array.ConvertAll(str.Split(','), float.Parse);
                    foreach (var item in res)
                        if (item < 0 || item > 10)
                        {
                            MessageBox.Show("Diem (0-10)");
                            res = null;
                            break;
                        }
                }
                else
                {
                    MessageBox.Show("No Input!");
                }
            }

            catch
            {
                MessageBox.Show("Định dạng sai,mỗi phần tử điểm cách nhau dấu cách phẩy " +
                    "\n Ví dụ: 7.5,5,8,10,9,10,8.5,9,10 ");
            }
            return res;
        }

        private string ToAverage(float[] listNum)
        {
            float res = 0;
            foreach (var num in listNum)
            {
                res += num / listNum.Length;
            }
            return res.ToString();
        }
        private string FindMin(float[] listNum)
        {
            float res = 11;
            foreach (var num in listNum)
            {
                res = Math.Min(res, num);
            }
            return res.ToString();
        }
        private string FindMax(float[] listNum)
        {
            float res = -1;
            foreach (var num in listNum)
            {
                res = Math.Max(res, num);
            }
            return res.ToString();
        }
        private string ToXepLoai(float[] listNum)
        {
            string res;
            if (float.Parse(FindMin(listNum)) >= 6.5 && float.Parse(ToAverage(listNum)) >= 8)
            {
                res = "Giỏi";
            }
            else if (float.Parse(FindMin(listNum)) >= 5 && float.Parse(ToAverage(listNum)) >= 6.5)
            {
                res = "Khá";
            }
            else if (float.Parse(FindMin(listNum)) >= 3.5 && float.Parse(ToAverage(listNum)) >= 5)
            {
                res = "Trung Bình";
            }
            else if (float.Parse(FindMin(listNum)) >= 2 && float.Parse(ToAverage(listNum)) >= 3.5)
            {
                res = "Yếu";
            }
            else
            {
                res = "Kém";
            }

            return res;
        }
        private int ToDau(float[] listDiem)
        {
            int res = 0;
            foreach (var item in listDiem)
            {
                if (item >= 5)
                    res++;
            }
            return res;
        }
        private int TokDau(float[] listDiem)
        {
            int res = 0;
            foreach (var item in listDiem)
            {
                if (item < 5)
                    res++;
            }
            return res;
        }
        private void ToDanhSachDiem(float[] listNum)
        {
            if (listNum != null)
            {
                List<string> result = new List<string>();
                int i = 1; // đếm các môn có trong list
                foreach (float diem in listNum)
                {
                    result.Add("Diem Mon " + i.ToString() + ": " + diem.ToString());
                    i++;
                }
                foreach (string str in result)
                {
                    textboxDiemMon.Text += str + "\r\n";
                }
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            listDiem = XuLiInput(textboxInput.Text);
            //Kiểm tra listDiem
            if (listDiem != null && listDiem.Length != 0)
            {
                textboxDiemMon.Text = "";
                ToDanhSachDiem(listDiem);
                textboxDTB.Text = ToAverage(listDiem);
                textboxMin.Text = FindMin(listDiem);
                textboxMax.Text = FindMax(listDiem);
                textboxXepLoai.Text = ToXepLoai(listDiem);
                textboxDau.Text = ToDau(listDiem).ToString();
                textboxKhongDau.Text = TokDau(listDiem).ToString();
                listDiem = null;
            }
            else
            {
                return;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            textboxInput.Text = "";
            textboxDau.Text = "";
            textboxDiemMon.Text = "";
            textboxMax.Text = "";
            textboxMin.Text = "";
            textboxDTB.Text = "";
            textboxXepLoai.Text = "";
            textboxKhongDau.Text = "";
            textboxDau.Text = "";
            listDiem = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void BtnExt_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }

    }
}
