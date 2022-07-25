
namespace _20520924_Lab01
{
    partial class Lab01_Bai01
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_LAB01_B01_CALC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(153, 22);
            this.textBox3.TabIndex = 2;
            // 
            // btn_LAB01_B01_CALC
            // 
            this.btn_LAB01_B01_CALC.Location = new System.Drawing.Point(34, 99);
            this.btn_LAB01_B01_CALC.Name = "btn_LAB01_B01_CALC";
            this.btn_LAB01_B01_CALC.Size = new System.Drawing.Size(113, 30);
            this.btn_LAB01_B01_CALC.TabIndex = 6;
            this.btn_LAB01_B01_CALC.Text = "Tinh";
            this.btn_LAB01_B01_CALC.UseVisualStyleBackColor = true;
            this.btn_LAB01_B01_CALC.Click += new System.EventHandler(this.Btn_LAB01_B01_CALC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "SO THU NHAT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "SO THU HAI  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "KET QUA :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btn_RESET
            // 
            this.btn_RESET.Location = new System.Drawing.Point(153, 99);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(113, 30);
            this.btn_RESET.TabIndex = 16;
            this.btn_RESET.Text = "Reset";
            this.btn_RESET.UseVisualStyleBackColor = true;
            this.btn_RESET.Click += new System.EventHandler(this.Btn_RESET_Click);
            // 
            // Lab01_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 190);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LAB01_B01_CALC);
            this.Controls.Add(this.textBox3);
            this.Name = "Lab01_Bai01";
            this.Text = "Bai 01: Tinh Tong 2 so nguyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_LAB01_B01_CALC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_RESET;
    }
}