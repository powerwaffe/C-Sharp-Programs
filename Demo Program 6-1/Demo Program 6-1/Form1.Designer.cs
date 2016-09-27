namespace Demo_Program_6_1
{
    partial class form1
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
            this.tbxExam1 = new System.Windows.Forms.TextBox();
            this.tbxExam2 = new System.Windows.Forms.TextBox();
            this.tbxAverage = new System.Windows.Forms.TextBox();
            this.btnCalcAverage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxExam1
            // 
            this.tbxExam1.Location = new System.Drawing.Point(100, 27);
            this.tbxExam1.Name = "tbxExam1";
            this.tbxExam1.Size = new System.Drawing.Size(100, 20);
            this.tbxExam1.TabIndex = 0;
            // 
            // tbxExam2
            // 
            this.tbxExam2.Location = new System.Drawing.Point(100, 68);
            this.tbxExam2.Name = "tbxExam2";
            this.tbxExam2.Size = new System.Drawing.Size(100, 20);
            this.tbxExam2.TabIndex = 1;
            // 
            // tbxAverage
            // 
            this.tbxAverage.Enabled = false;
            this.tbxAverage.Location = new System.Drawing.Point(100, 213);
            this.tbxAverage.Name = "tbxAverage";
            this.tbxAverage.Size = new System.Drawing.Size(100, 20);
            this.tbxAverage.TabIndex = 2;
            // 
            // btnCalcAverage
            // 
            this.btnCalcAverage.Location = new System.Drawing.Point(113, 94);
            this.btnCalcAverage.Name = "btnCalcAverage";
            this.btnCalcAverage.Size = new System.Drawing.Size(75, 37);
            this.btnCalcAverage.TabIndex = 3;
            this.btnCalcAverage.Text = "Calculate Average";
            this.btnCalcAverage.UseVisualStyleBackColor = true;
            this.btnCalcAverage.Click += new System.EventHandler(this.btnCalcAverage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exam 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exam 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcAverage);
            this.Controls.Add(this.tbxAverage);
            this.Controls.Add(this.tbxExam2);
            this.Controls.Add(this.tbxExam1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxExam1;
        private System.Windows.Forms.TextBox tbxExam2;
        private System.Windows.Forms.TextBox tbxAverage;
        private System.Windows.Forms.Button btnCalcAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

