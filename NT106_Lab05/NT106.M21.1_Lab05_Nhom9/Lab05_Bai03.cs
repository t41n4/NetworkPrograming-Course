﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace NT106.M21._1_Lab05_Nhom9
{
    public partial class Lab05_Bai03 : Form
    {
        public Lab05_Bai03()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Attach.Text = ofd.FileName;
            }
        }

        private void CleanUp()
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtSubject.Text = "";
            txtPassword.Text = "";
            txtBody.Text = "";
            Attach.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mailfrom = txtFrom.Text.Trim();
            string mailto = txtTo.Text.Trim();
            string password = txtPassword.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string body = txtBody.Text.Trim();

            SendMail(subject, body, mailto, mailfrom, password);
        }
        private void SendMail(string subject, string body, string mailto, string mailfrom, string password)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mailfrom, password);

                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    message.From = fromAddress;
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.To.Add(mailto);
                    message.Body = body;

                    if (Attach.Text != "")
                    {
                        Attachment attachment = new Attachment(Attach.Text);
                        message.Attachments.Add(attachment);
                    }

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Send successfully!");
                        CleanUp();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        CleanUp();
                    }
                }
            }

        }
    }
}
