using MimeKit;
using System;
using System.Windows.Forms;

namespace NT106.M21__Nhom09_55
{
    public partial class FormWriteMail : Form
    {
        private MimeMessage message;

        public FormWriteMail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                message = new MimeMessage();

                message.From.Add(new MailboxAddress(tbFromName.Text, tbFromEmail.Text));

                message.To.Add(MailboxAddress.Parse(tbToEmail.Text));

                message.Subject = tbSubject.Text;

                if (pathAttachment != "")
                {
                    var builder = new BodyBuilder();

                    builder.Attachments.Add(pathAttachment);

                    builder.TextBody = rtbBody.Text;

                    message.Body = builder.ToMessageBody();
                }
                else
                {
                    message.Body = new TextPart("Plain")
                    {
                        Text = rtbBody.Text
                    };
                }

                MailApp.WriteClient.Send(message);
                MessageBox.Show("Send Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string pathAttachment;

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            pathAttachment = openFile.FileName;
            labelFileName.Text = "File Attached:" + openFile.FileName;
        }

        public void FormWriteMail_Load(object sender, EventArgs e)
        {
            tbFromEmail.Text = MailApp.emailAddress;
        }
    }
}