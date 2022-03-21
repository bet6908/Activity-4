namespace Activity_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_count = new System.Windows.Forms.Button();
            this.txt_inputSec = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.lbl_inputSec = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hrs = new System.Windows.Forms.TextBox();
            this.txt_months = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_count.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_count.Location = new System.Drawing.Point(633, 370);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(114, 53);
            this.btn_count.TabIndex = 0;
            this.btn_count.Text = "Convert";
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // txt_inputSec
            // 
            this.txt_inputSec.Location = new System.Drawing.Point(388, 101);
            this.txt_inputSec.Name = "txt_inputSec";
            this.txt_inputSec.Size = new System.Drawing.Size(100, 23);
            this.txt_inputSec.TabIndex = 1;
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(388, 173);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(100, 23);
            this.txt_min.TabIndex = 2;
            // 
            // lbl_inputSec
            // 
            this.lbl_inputSec.AutoSize = true;
            this.lbl_inputSec.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_inputSec.Location = new System.Drawing.Point(217, 101);
            this.lbl_inputSec.Name = "lbl_inputSec";
            this.lbl_inputSec.Size = new System.Drawing.Size(119, 22);
            this.lbl_inputSec.TabIndex = 3;
            this.lbl_inputSec.Text = "Input seconds";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_output.Location = new System.Drawing.Point(520, 174);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(75, 22);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(520, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(520, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Months";
            // 
            // txt_hrs
            // 
            this.txt_hrs.Location = new System.Drawing.Point(388, 239);
            this.txt_hrs.Name = "txt_hrs";
            this.txt_hrs.Size = new System.Drawing.Size(100, 23);
            this.txt_hrs.TabIndex = 7;
            // 
            // txt_months
            // 
            this.txt_months.Location = new System.Drawing.Point(388, 314);
            this.txt_months.Name = "txt_months";
            this.txt_months.Size = new System.Drawing.Size(100, 23);
            this.txt_months.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_months);
            this.Controls.Add(this.txt_hrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_inputSec);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.txt_inputSec);
            this.Controls.Add(this.btn_count);
            this.Name = "Form1";
            this.Text = "Count seconds by minutes, hours and days";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_count;
        private TextBox txt_inputSec;
        private TextBox txt_min;
        private Label lbl_inputSec;
        private Label lbl_output;
        private Label label1;
        private Label label2;
        private TextBox txt_hrs;
        private TextBox txt_months;
    }
}