namespace NT106.M21._1_Lab04_Nhom9
{
    partial class Lab04_Bai04
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
            this.Lab4_txtURL = new System.Windows.Forms.TextBox();
            this.Lab4_btnSource = new System.Windows.Forms.Button();
            this.Lab4_btnDownload = new System.Windows.Forms.Button();
            this.Lab4_btnSearch = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Lab4_txtURL
            // 
            this.Lab4_txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab4_txtURL.Location = new System.Drawing.Point(22, 12);
            this.Lab4_txtURL.Name = "Lab4_txtURL";
            this.Lab4_txtURL.Size = new System.Drawing.Size(731, 30);
            this.Lab4_txtURL.TabIndex = 0;
            this.Lab4_txtURL.Text = "https://";
            this.Lab4_txtURL.TextChanged += new System.EventHandler(this.Lab4_txtURL_TextChanged);
            this.Lab4_txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lab4_txtURL_KeyDown);
            // 
            // Lab4_btnSource
            // 
            this.Lab4_btnSource.BackgroundImage = global::NT106.M21._1_Lab04_Nhom9.Properties.Resources.ViewBtn;
            this.Lab4_btnSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lab4_btnSource.Location = new System.Drawing.Point(934, 8);
            this.Lab4_btnSource.Name = "Lab4_btnSource";
            this.Lab4_btnSource.Size = new System.Drawing.Size(40, 40);
            this.Lab4_btnSource.TabIndex = 3;
            this.Lab4_btnSource.UseVisualStyleBackColor = true;
            this.Lab4_btnSource.Click += new System.EventHandler(this.Lab4_btnSource_Click);
            // 
            // Lab4_btnDownload
            // 
            this.Lab4_btnDownload.BackgroundImage = global::NT106.M21._1_Lab04_Nhom9.Properties.Resources.DownloadBtn;
            this.Lab4_btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lab4_btnDownload.Location = new System.Drawing.Point(857, 9);
            this.Lab4_btnDownload.Name = "Lab4_btnDownload";
            this.Lab4_btnDownload.Size = new System.Drawing.Size(40, 40);
            this.Lab4_btnDownload.TabIndex = 2;
            this.Lab4_btnDownload.UseVisualStyleBackColor = true;
            this.Lab4_btnDownload.Click += new System.EventHandler(this.Lab4_btnDownload_Click);
            // 
            // Lab4_btnSearch
            // 
            this.Lab4_btnSearch.BackgroundImage = global::NT106.M21._1_Lab04_Nhom9.Properties.Resources.SearchBtn;
            this.Lab4_btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lab4_btnSearch.Location = new System.Drawing.Point(782, 9);
            this.Lab4_btnSearch.Name = "Lab4_btnSearch";
            this.Lab4_btnSearch.Size = new System.Drawing.Size(40, 40);
            this.Lab4_btnSearch.TabIndex = 1;
            this.Lab4_btnSearch.UseVisualStyleBackColor = true;
            this.Lab4_btnSearch.Click += new System.EventHandler(this.Lab4_btnSearch_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1006, 465);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Lab04_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 521);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Lab4_btnSource);
            this.Controls.Add(this.Lab4_btnDownload);
            this.Controls.Add(this.Lab4_btnSearch);
            this.Controls.Add(this.Lab4_txtURL);
            this.Name = "Lab04_Bai04";
            this.Text = "Lab04_Bai4";
            this.Load += new System.EventHandler(this.Lab04_Bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lab4_txtURL;
        private System.Windows.Forms.Button Lab4_btnSearch;
        private System.Windows.Forms.Button Lab4_btnDownload;
        private System.Windows.Forms.Button Lab4_btnSource;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}