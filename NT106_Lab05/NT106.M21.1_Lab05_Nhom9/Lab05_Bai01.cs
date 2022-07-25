using System;

using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace NT106.M21._1_Lab05_Nhom9
{
    public partial class Lab05_Bai01 : Form
    {
        public Lab05_Bai01()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = tbFrom.Text.ToString().Trim();
                string mailto = tbTo.Text.ToString().Trim();
                string password = tbPassword.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSubject.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = BodyBox.Text.ToString();
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Successfully sent!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
