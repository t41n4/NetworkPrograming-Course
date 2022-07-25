namespace NT106.M21._1_Lab05_Nhom9
{
    partial class Lab05_Bai03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.RichTextBox();
            this.txtFrom = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.RichTextBox();
            this.Attach = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(105, 70);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(390, 25);
            this.txtTo.TabIndex = 8;
            this.txtTo.Text = "";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(105, 31);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(390, 25);
            this.txtFrom.TabIndex = 6;
            this.txtFrom.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(105, 120);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(896, 25);
            this.txtSubject.TabIndex = 9;
            this.txtSubject.Text = "";
            // 
            // Attach
            // 
            this.Attach.Enabled = false;
            this.Attach.Location = new System.Drawing.Point(531, 70);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(361, 25);
            this.Attach.TabIndex = 9;
            this.Attach.Text = "";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(898, 66);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(103, 31);
            this.btnAttach.TabIndex = 10;
            this.btnAttach.Text = "Attachment";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Body:";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(40, 182);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(961, 276);
            this.txtBody.TabIndex = 12;
            this.txtBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(910, 467);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 31);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(620, 27);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(381, 22);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Lab05_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 518);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab05_Bai03";
            this.Text = "Lab05_Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtTo;
        private System.Windows.Forms.RichTextBox txtFrom;
        private System.Windows.Forms.RichTextBox txtSubject;
        private System.Windows.Forms.RichTextBox Attach;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPassword;
    }
}