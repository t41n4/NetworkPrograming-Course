
namespace NT106.M21__Nhom09_55
{
    partial class FormWriteMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.tbFromName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbFromEmail = new System.Windows.Forms.TextBox();
            this.tbToEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(103, 96);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(670, 275);
            this.rtbBody.TabIndex = 0;
            this.rtbBody.Text = "Hello Friend!!";
            // 
            // tbFromName
            // 
            this.tbFromName.Location = new System.Drawing.Point(151, 9);
            this.tbFromName.Name = "tbFromName";
            this.tbFromName.Size = new System.Drawing.Size(177, 22);
            this.tbFromName.TabIndex = 1;
            this.tbFromName.Text = "Nguyen Anh Tai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(103, 68);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(473, 22);
            this.tbSubject.TabIndex = 1;
            this.tbSubject.Text = "Hello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Body";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(103, 403);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(210, 35);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbFromEmail
            // 
            this.tbFromEmail.Location = new System.Drawing.Point(396, 7);
            this.tbFromEmail.Name = "tbFromEmail";
            this.tbFromEmail.Size = new System.Drawing.Size(180, 22);
            this.tbFromEmail.TabIndex = 1;
            this.tbFromEmail.Text = "n4t41.trash@gmail.com";
            // 
            // tbToEmail
            // 
            this.tbToEmail.Location = new System.Drawing.Point(396, 35);
            this.tbToEmail.Name = "tbToEmail";
            this.tbToEmail.Size = new System.Drawing.Size(180, 22);
            this.tbToEmail.TabIndex = 1;
            this.tbToEmail.Text = "n4t41.trash@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // btnAttachment
            // 
            this.btnAttachment.Location = new System.Drawing.Point(620, 12);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(153, 73);
            this.btnAttachment.TabIndex = 3;
            this.btnAttachment.Text = "Attachment ";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(100, 374);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(79, 17);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "File Name: ";
            // 
            // FormWriteMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbToEmail);
            this.Controls.Add(this.tbFromEmail);
            this.Controls.Add(this.tbFromName);
            this.Controls.Add(this.rtbBody);
            this.Name = "FormWriteMail";
            this.Text = "FormWriteMail";
            this.Load += new System.EventHandler(this.FormWriteMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.TextBox tbFromName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbFromEmail;
        private System.Windows.Forms.TextBox tbToEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.Label labelFileName;
    }
}