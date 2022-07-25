
namespace _20520924_Lab01
{
    partial class Lab01_Bai04
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.bnt_Doi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTyGia = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN ĐỔI TIỀN TỆ";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(277, 44);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(100, 22);
            this.textInput.TabIndex = 1;
            // 
            // bnt_Doi
            // 
            this.bnt_Doi.Location = new System.Drawing.Point(277, 72);
            this.bnt_Doi.Name = "bnt_Doi";
            this.bnt_Doi.Size = new System.Drawing.Size(113, 30);
            this.bnt_Doi.TabIndex = 2;
            this.bnt_Doi.Text = "Đổi";
            this.bnt_Doi.UseVisualStyleBackColor = true;
            this.bnt_Doi.Click += new System.EventHandler(this.Bnt_Doi_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHẬP SỐ TIỀN CẦN ĐỔI:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(277, 108);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(153, 22);
            this.textResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TO VND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TỶ GIÁ:";
            // 
            // textTyGia
            // 
            this.textTyGia.Location = new System.Drawing.Point(540, 44);
            this.textTyGia.Name = "textTyGia";
            this.textTyGia.ReadOnly = true;
            this.textTyGia.Size = new System.Drawing.Size(153, 22);
            this.textTyGia.TabIndex = 8;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(580, 129);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(113, 30);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_RESET
            // 
            this.btn_RESET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RESET.Location = new System.Drawing.Point(482, 129);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(92, 29);
            this.btn_RESET.TabIndex = 17;
            this.btn_RESET.Text = "RESET";
            this.btn_RESET.UseVisualStyleBackColor = true;
            this.btn_RESET.Click += new System.EventHandler(this.Btn_RESET_Click);
            // 
            // Lab01_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(775, 171);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.textTyGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnt_Doi);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai04";
            this.Text = "Lab01_Bai04";
            this.Load += new System.EventHandler(this.Lab01_Bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button bnt_Doi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTyGia;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_RESET;
    }
}