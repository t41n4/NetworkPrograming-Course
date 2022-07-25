using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExW02_205020924
{
    public partial class PictureViewer : Form
    {
        OpenFileDialog openFilesPic = new OpenFileDialog();
        FolderBrowserDialog openFolPic = new FolderBrowserDialog();
        string[] pathList;
        int indexPic = 0;
        public PictureViewer()
        {
            
            InitializeComponent();
        }

      

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           if( pathList == null)
            {
                MessageBox.Show("Chưa có dữ liệu, Xin Hãy chọn Phương thức lấy file ở ComboBox");
                return;
            }
           else if (indexPic < pathList.Count())
            {
                
                pictureBox.Image = new Bitmap(pathList[indexPic]);
                indexPic++;
            }
            else
            {
                try
                {
                    indexPic = 0;
                    pictureBox.Image = new Bitmap(pathList[indexPic]);
                    indexPic++;

                }
                catch
                {

                    MessageBox.Show("Không tìm thấy hình ảnh nào");
                    return;
                }

            }
        }
        /// <summary>
        /// Lấy Image từ những file đã chọn
        /// </summary>
        private void OpenPicBySelectFile()
        {
            pathList = null;
            pictureBox.Image = null;
            openFilesPic.Filter = "Image files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFilesPic.FilterIndex = 1;
            openFilesPic.Multiselect = true;
            if(openFilesPic.ShowDialog() == DialogResult.OK)
                pathList = openFilesPic.FileNames;
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Files nào cả!");
                return;
            }
        }
        /// <summary>
        /// Lấy Image từ một folder đã chọn
        /// </summary>
        private void OpenPicBySelectFolder()
        {
            pathList = null;
            pictureBox.Image = null; 
            if (openFolPic.ShowDialog() == DialogResult.OK)
            {
                
                
                List<string> list = new List<string>();
                pathList = Directory.GetFiles(openFolPic.SelectedPath, "*.png", SearchOption.AllDirectories);
                foreach (string path in pathList)
                {
                    list.Add(path);
                }
                pathList = Directory.GetFiles(openFolPic.SelectedPath, "*.bmp", SearchOption.AllDirectories);
         
                foreach (string path in pathList)
                {
                    list.Add(path);
                }
                pathList = Directory.GetFiles(openFolPic.SelectedPath, "*.jpeg", SearchOption.AllDirectories);               
                foreach (string path in pathList)
                {
                    list.Add(path);
                }
                pathList = Directory.GetFiles(openFolPic.SelectedPath, "*.jpg", SearchOption.AllDirectories);
                foreach (string path in pathList)
                {
                    list.Add(path);
                }

                pathList  = list.ToArray();


            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Folder nào cả!");
                return;
            }
        }

        private void PictureViewer_Load(object sender, EventArgs e)
        {

            comboBox.Items.Add("Files");
            comboBox.Items.Add("Folder");


        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.Text == "Files")
            {
                OpenPicBySelectFile();
            }
            if (comboBox.Text == "Folder")
            {
                OpenPicBySelectFolder();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
