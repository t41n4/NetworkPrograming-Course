using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Windows.Forms;

namespace NT106.M21__Nhom09_55
{
    public partial class MailApp : Form
    {
        public static SmtpClient WriteClient;
        public static ImapClient ReadClient;
        public static string emailAddress;

        public MailApp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            emailAddress = tbLogin.Text;
            string password = textBox2.Text;
            WriteClient = new SmtpClient();
            ReadClient = new ImapClient();

            try
            {
                WriteClient.Connect("smtp.gmail.com", 465, true);
                ReadClient.AuthenticationMechanisms.Remove("XOAUTH2");
                WriteClient.Authenticate(emailAddress, password);

                ReadClient.Connect("imap.gmail.com", 993, true);
                ReadClient.Authenticate(emailAddress, password);
                MessageBox.Show("Login Success!");
                Control control = new Control();
                this.Hide();
                control.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void MailApp_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}