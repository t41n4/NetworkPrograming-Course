
namespace NT106.M21__Nhom09_55
{
    partial class FormReadMail
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbAttach = new System.Windows.Forms.Label();
            this.btnOpenAttF = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(483, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(528, 420);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "LOADING..."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 420);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbAttach
            // 
            this.lbAttach.AutoSize = true;
            this.lbAttach.Location = new System.Drawing.Point(489, 435);
            this.lbAttach.Name = "lbAttach";
            this.lbAttach.Size = new System.Drawing.Size(48, 17);
            this.lbAttach.TabIndex = 3;
            this.lbAttach.Text = "Attach";
            // 
            // btnOpenAttF
            // 
            this.btnOpenAttF.Location = new System.Drawing.Point(483, 455);
            this.btnOpenAttF.Name = "btnOpenAttF";
            this.btnOpenAttF.Size = new System.Drawing.Size(528, 42);
            this.btnOpenAttF.TabIndex = 4;
            this.btnOpenAttF.Text = "Open Attach File";
            this.btnOpenAttF.UseVisualStyleBackColor = true;
            this.btnOpenAttF.Click += new System.EventHandler(this.btnOpenAttF_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(462, 42);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 521);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenAttF);
            this.Controls.Add(this.lbAttach);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormReadMail";
            this.Text = "FormReadMail";
            this.Load += new System.EventHandler(this.FormReadMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbAttach;
        private System.Windows.Forms.Button btnOpenAttF;
        private System.Windows.Forms.Button btnRefresh;
    }
}