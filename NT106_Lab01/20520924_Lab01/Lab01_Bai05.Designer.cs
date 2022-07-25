
namespace _20520924_Lab01
{
    partial class Lab01_Bai05
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
            this.textboxNum01 = new System.Windows.Forms.TextBox();
            this.textboxNum02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 01:";
            // 
            // textboxNum01
            // 
            this.textboxNum01.Location = new System.Drawing.Point(106, 15);
            this.textboxNum01.Name = "textboxNum01";
            this.textboxNum01.Size = new System.Drawing.Size(100, 22);
            this.textboxNum01.TabIndex = 1;
            // 
            // textboxNum02
            // 
            this.textboxNum02.Location = new System.Drawing.Point(106, 46);
            this.textboxNum02.Name = "textboxNum02";
            this.textboxNum02.Size = new System.Drawing.Size(100, 22);
            this.textboxNum02.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 02:";
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.SystemColors.Control;
            this.textResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResult.Location = new System.Drawing.Point(21, 96);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(417, 171);
            this.textResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(363, 9);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 28);
            this.btn_Calc.TabIndex = 6;
            this.btn_Calc.Text = "Calc";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(363, 38);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(363, 67);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 26);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 283);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxNum02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxNum01);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai05";
            this.Text = "Lab01_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNum01;
        private System.Windows.Forms.TextBox textboxNum02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Exit;
    }
}