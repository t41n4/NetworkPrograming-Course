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
    public partial class ReadWriteTxt : Form
    {
        FileStream fs;
        byte[] fileContents;
        AsyncCallback callback;
        delegate void InfoMessageDel(String info);
        public ReadWriteTxt()
        {
            InitializeComponent();
        }

        private void btnReadAsync_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtOpenfileDialog = new OpenFileDialog();
            txtOpenfileDialog.ShowDialog();
            try
            {
                fs = new FileStream(txtOpenfileDialog.FileName, FileMode.Open);
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn file");
                //MessageBox.Show(ex.Message);
                return;
            }

            callback = new AsyncCallback(fs_StateChanged);
            fileContents = new byte[fs.Length];
            fs.BeginRead(fileContents, 0, (int)fs.Length, callback, null);




        }
     
        private void btnReadSync_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtOpenfileDialog = new OpenFileDialog();
            txtOpenfileDialog.ShowDialog();
            
            try
            {
                fs = new FileStream(txtOpenfileDialog.FileName, FileMode.Open);
            }
            catch
            {
                
                string er = "Bạn Chưa Chọn File";
                MessageBox.Show(er);
                    return;
            }
            fs.Seek(0,SeekOrigin.Begin);
            fileContents = new byte[fs.Length];
            fs.Read(fileContents, 0, (int)fs.Length);
            string s = Encoding.UTF8.GetString(fileContents);
            InfoMessage(s);
            fs.Close();
        }

        private void fs_StateChanged(IAsyncResult asyncResult)
        {
            if (asyncResult.IsCompleted)
            {
                string s = Encoding.UTF8.GetString(fileContents);
                InfoMessage(s);

            }
            fs.Close();
        }
        private void InfoMessage(string s)
        {
            if (this.tbResult.InvokeRequired)
            {
                InfoMessageDel msg = new InfoMessageDel(InfoMessage);
                this.Invoke(msg, new object[] { s });
            }
            else
            {
                tbResult.Text = s;
            }
        }
      

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadWriteTxt_Load(object sender, EventArgs e)
        {

        }

        private void btnWriteAsync_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter= "Txt Files (*.txt)|*.txt";
            if (tbResult.Text == "")
            {
                MessageBox.Show("TextBox không có dữ liệu \nXin Hãy nhập dữ liệu để truyền vào file");
                return;
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {    
                FileStream fs = new FileStream(saveFileDialog.FileName,FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs,Encoding.UTF8);
                string content = tbResult.Text;  
                bw.Write(content);
                tbResult.Text = "";
                bw.Close();
            }
            else
            {
                return;
            }
        }

        private void btnWriteToEx_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            OpenFileDialog openTxt = new OpenFileDialog();
            openTxt.Filter = "Txt files (*.txt)| *.txt";
            if (tbResult.Text == "")
            {
                MessageBox.Show("TextBox không có dữ liệu \nXin Hãy nhập dữ liệu để truyền vào file");
                return;
            }
            if (openTxt.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openTxt.FileName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                foreach (char line in tbResult.Text)
                    sw.Write(line);
                tbResult.Text = "";
                sw.Close();
            }
            else
            {
                return;
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            PictureViewer pic = new PictureViewer();
            pic.Show();
        }

       
    }
}
