using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NT106.M21__Nhom09_55
{
    public partial class FormReadMail : Form
    {
        private List<EmailListData> emailListData;
        private string path;

        public FormReadMail()
        {
            InitializeComponent();
        }

        private async void DownLoadEmail()
        {
            var folder = MailApp.ReadClient.GetFolder("INBOX");

            await folder.OpenAsync(FolderAccess.ReadOnly);

            emailListData = new List<EmailListData>();

            foreach (var item in folder)
            {
                emailListData.Add(new EmailListData()
                {
                    Id = item.MessageId,
                    Subject = item.Subject,
                    Content = item.TextBody,
                    File = item.Attachments,
                });
            }

            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            if (emailListData.Count == 0)
            {
                listBox1.Items.Add("Mail Folder is empty!");
                return;
            }
            else
            {
                foreach (var item in emailListData)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void FormReadMail_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = emailListData;
            listBox1.DisplayMember = "Subject";
            DownLoadEmail();
            btnOpenAttF.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string messageid = ((EmailListData)((ListBox)sender).SelectedItem).Id;

            foreach (var item in emailListData)
            {
                if (messageid == item.Id)
                {
                    richTextBox1.Text = item.Content;
                    ReadAttachment(item);
                    break;
                }
            }
        }

        private void ReadAttachment(EmailListData item)
        {
            MimeEntity attachment = item.File.FirstOrDefault();

            if (attachment == null)
            {
                lbAttach.Text = "Attach File: No";
                btnOpenAttF.Enabled = false;
                return;
            }
            btnOpenAttF.Enabled = true;
            foreach (MimeEntity attach in item.File)
            {
                var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;

                using (var stream = File.Create(fileName))
                {
                    path = stream.Name;
                    lbAttach.Text = "Attach File: " + stream.Name;

                    if (attachment is MessagePart)
                    {
                        var rfc822 = (MessagePart)attachment;
                        rfc822.Message.WriteTo(stream);
                    }
                    else
                    {
                        var part = (MimePart)attachment;
                        part.Content.DecodeTo(stream);
                    }
                }
            }
        }

        private void btnOpenAttF_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DownLoadEmail();
        }
    }
}