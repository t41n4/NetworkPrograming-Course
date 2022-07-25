
namespace NT106.M21._1_Lab04_Nhom9
{
    partial class Lab04_Bai01
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
            this.rtxResponse = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxResponse
            // 
            this.rtxResponse.Location = new System.Drawing.Point(22, 70);
            this.rtxResponse.Name = "rtxResponse";
            this.rtxResponse.Size = new System.Drawing.Size(746, 361);
            this.rtxResponse.TabIndex = 5;
            this.rtxResponse.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(636, 19);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(142, 45);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(31, 27);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(574, 32);
            this.txtURL.TabIndex = 3;
            this.txtURL.Text = "http://";
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // Lab04_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxResponse);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtURL);
            this.Name = "Lab04_Bai01";
            this.Text = "Lab04 Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxResponse;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtURL;
    }
}