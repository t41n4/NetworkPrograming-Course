
namespace ExW02_205020924
{
    partial class ReadWriteTxt
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
            this.btnReadAsync = new System.Windows.Forms.Button();
            this.btnReadSync = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnWriteAsync = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnWriteToEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadAsync
            // 
            this.btnReadAsync.Location = new System.Drawing.Point(670, 12);
            this.btnReadAsync.Name = "btnReadAsync";
            this.btnReadAsync.Size = new System.Drawing.Size(118, 33);
            this.btnReadAsync.TabIndex = 0;
            this.btnReadAsync.Text = "Read Async";
            this.btnReadAsync.UseVisualStyleBackColor = true;
            this.btnReadAsync.Click += new System.EventHandler(this.btnReadAsync_Click);
            // 
            // btnReadSync
            // 
            this.btnReadSync.Location = new System.Drawing.Point(670, 51);
            this.btnReadSync.Name = "btnReadSync";
            this.btnReadSync.Size = new System.Drawing.Size(118, 33);
            this.btnReadSync.TabIndex = 3;
            this.btnReadSync.Text = "Read Sync";
            this.btnReadSync.UseVisualStyleBackColor = true;
            this.btnReadSync.Click += new System.EventHandler(this.btnReadSync_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(19, 69);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(645, 369);
            this.tbResult.TabIndex = 2;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // btnWriteAsync
            // 
            this.btnWriteAsync.Location = new System.Drawing.Point(422, 12);
            this.btnWriteAsync.Name = "btnWriteAsync";
            this.btnWriteAsync.Size = new System.Drawing.Size(118, 51);
            this.btnWriteAsync.TabIndex = 4;
            this.btnWriteAsync.Text = "Write to New File";
            this.btnWriteAsync.UseVisualStyleBackColor = true;
            this.btnWriteAsync.Click += new System.EventHandler(this.btnWriteAsync_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(670, 90);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(118, 31);
            this.btnPicture.TabIndex = 5;
            this.btnPicture.Text = "Pictures";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnWriteToEx
            // 
            this.btnWriteToEx.Location = new System.Drawing.Point(546, 12);
            this.btnWriteToEx.Name = "btnWriteToEx";
            this.btnWriteToEx.Size = new System.Drawing.Size(118, 51);
            this.btnWriteToEx.TabIndex = 6;
            this.btnWriteToEx.Text = "Write to Existing File";
            this.btnWriteToEx.UseVisualStyleBackColor = true;
            this.btnWriteToEx.Click += new System.EventHandler(this.btnWriteToEx_Click);
            // 
            // ReadWriteTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWriteToEx);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnWriteAsync);
            this.Controls.Add(this.btnReadSync);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnReadAsync);
            this.Name = "ReadWriteTxt";
            this.Text = "ReadWriteTxt";
            this.Load += new System.EventHandler(this.ReadWriteTxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadAsync;
        private System.Windows.Forms.Button btnReadSync;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnWriteAsync;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnWriteToEx;
    }
}

