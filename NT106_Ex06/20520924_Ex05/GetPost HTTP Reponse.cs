using System;
using System.Collections;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Web;
using System.Threading;

namespace _20520924_Ex05
{
    public partial class HttpReponse : Form
    {
        public HttpReponse()
        {
            InitializeComponent();
        }

        public string Post(string URL, string Post)
        {
            try
            {
                // tạo các đối tượng Request và Response
                HttpWebRequest httpRequest;
                HttpWebResponse httpResponse;
                // biến StreamReader để đọc dữ liệu
                StreamReader bodyReader;

                //biến Stream Để nhận dữ liệu
                Stream responseStream;
                Stream requestStream;
                //điều chỉnh các thông số của httpRequest
                httpRequest = (HttpWebRequest)WebRequest.Create(URL);
                httpRequest.Method = "POST";
                httpRequest.ContentType = "application/x-www-form-urlencoded";
                httpRequest.ContentLength = Post.Length;
                // tạo một luồng Request để gửi thông điệp
                requestStream = httpRequest.GetRequestStream();
                requestStream.Write(Encoding.ASCII.GetBytes(Post), 0, Post.Length);
                requestStream.Close();
                // tạo luồng Reponse Để nhận thông điệp
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                responseStream = httpResponse.GetResponseStream();

                bodyReader = new StreamReader(responseStream);

                string res = "HTTP/" + httpResponse.ProtocolVersion.ToString()
                              + " " + (int)httpResponse.StatusCode
                              + " " + httpResponse.StatusCode.ToString()
                              + "\r\n" + httpResponse.Headers.ToString()
                              + bodyReader.ReadToEnd();
                return res;
            }
            catch (Exception e)
            {
               
                MessageBox.Show(e.Message);
                return "Nothing";
            }
 
        }
        private string Get(string uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

                request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream streamResponse = response.GetResponseStream();

                StreamReader reader = new StreamReader(streamResponse);

                WebHeaderCollection headerCollection = response.Headers;

                string res = "HTTP/" + response.ProtocolVersion.ToString() + " " + (int)response.StatusCode + " " + response.StatusCode.ToString() + "\r\n" + headerCollection.ToString() + reader.ReadToEnd();

                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "Nothing";
            }      
            
        }
        private string HelloToUrl(string Url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
              
                    return response.ResponseUri.Scheme == "http" ? "http" : "https";     
            }
            catch (Exception)
            {

                return "nothing";
            }
           
         
        }
        private void Go() {
            string test = HelloToUrl("http://" + tbUrl.Text) ;
            if (!tbUrl.Text.ToLower().StartsWith("http://") || !tbUrl.Text.ToLower().StartsWith("https://"))
                if (test == "http")
                {
                    tbUrl.Text = "http://" + tbUrl.Text;
                    tbResult.Text = Get(tbUrl.Text);
                }
                else if (test == "https")
                {
                    tbUrl.Text = "https://" + tbUrl.Text;
                    tbResult.Text = Get(tbUrl.Text);
                } else tbResult.Text = "nothing";
        }
        private void BtnGet_Click(object sender, System.EventArgs e)
        {
            //tbResult.Text = Post(tbUrl.Text, HttpUtility.UrlEncode(tbPost.Text));
            Go();
            
        }

        private void TbUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Go();
            }
        }

     
    }
}