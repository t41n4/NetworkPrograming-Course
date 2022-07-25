namespace NT106.M21._1_Lab04_Nhom9
{
    partial class SourceHTML
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
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSource
            // 
            this.rtbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSource.Location = new System.Drawing.Point(2, 3);
            this.rtbSource.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(949, 592);
            this.rtbSource.TabIndex = 1;
            this.rtbSource.Text = "";
            this.rtbSource.TextChanged += new System.EventHandler(this.rtbSource_TextChanged);
            // 
            // SouceHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 596);
            this.Controls.Add(this.rtbSource);
            this.Name = "SouceHTML";
            this.Text = "SouceHTML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSource;
    }
}