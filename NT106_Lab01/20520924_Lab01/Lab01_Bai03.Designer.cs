
namespace _20520924_Lab01
{
    partial class Lab01_Bai03
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
            this.btn_READ = new System.Windows.Forms.Button();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_READ
            // 
            this.btn_READ.Location = new System.Drawing.Point(293, 19);
            this.btn_READ.Name = "btn_READ";
            this.btn_READ.Size = new System.Drawing.Size(187, 30);
            this.btn_READ.TabIndex = 7;
            this.btn_READ.Text = "Read";
            this.btn_READ.UseVisualStyleBackColor = true;
            this.btn_READ.Click += new System.EventHandler(this.Btn_READ_Click);
            // 
            // btn_RESET
            // 
            this.btn_RESET.Location = new System.Drawing.Point(293, 55);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(187, 30);
            this.btn_RESET.TabIndex = 8;
            this.btn_RESET.Text = "Reset";
            this.btn_RESET.UseVisualStyleBackColor = true;
            this.btn_RESET.Click += new System.EventHandler(this.Btn_RESET_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(293, 91);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(187, 30);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(206, 27);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(39, 22);
            this.textInput.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nhập vào số nguyên từ 0 - 9:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "RESULT :";
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(15, 99);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(153, 22);
            this.textOutput.TabIndex = 20;
            // 
            // Lab01_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 149);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.btn_READ);
            this.Name = "Lab01_Bai03";
            this.Text = "Bai 03: Doc So";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_READ;
        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOutput;
    }
}