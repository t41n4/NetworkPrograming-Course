
namespace _20520924_Ex05
{
    partial class HttpReponse
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
            this.btnGet = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(388, 7);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(129, 27);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(11, 45);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(530, 333);
            this.tbResult.TabIndex = 1;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(370, 22);
            this.tbUrl.TabIndex = 3;
            this.tbUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbUrl_KeyDown);
            // 
            // HttpReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 390);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnGet);
            this.Name = "HttpReponse";
            this.Text = "HttpReponse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbUrl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

