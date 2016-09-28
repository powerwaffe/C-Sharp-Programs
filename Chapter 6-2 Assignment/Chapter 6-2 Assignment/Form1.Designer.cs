namespace Chapter_6_2_Assignment
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxGrade1 = new System.Windows.Forms.TextBox();
            this.tbxGrade2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAverage = new System.Windows.Forms.TextBox();
            this.btnCalcAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade 2:";
            // 
            // tbxGrade1
            // 
            this.tbxGrade1.Location = new System.Drawing.Point(85, 40);
            this.tbxGrade1.Name = "tbxGrade1";
            this.tbxGrade1.Size = new System.Drawing.Size(148, 22);
            this.tbxGrade1.TabIndex = 2;
            // 
            // tbxGrade2
            // 
            this.tbxGrade2.Location = new System.Drawing.Point(85, 93);
            this.tbxGrade2.Name = "tbxGrade2";
            this.tbxGrade2.Size = new System.Drawing.Size(148, 22);
            this.tbxGrade2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average";
            // 
            // tbxAverage
            // 
            this.tbxAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAverage.Enabled = false;
            this.tbxAverage.Location = new System.Drawing.Point(83, 203);
            this.tbxAverage.Name = "tbxAverage";
            this.tbxAverage.Size = new System.Drawing.Size(148, 22);
            this.tbxAverage.TabIndex = 5;
            // 
            // btnCalcAverage
            // 
            this.btnCalcAverage.Location = new System.Drawing.Point(59, 310);
            this.btnCalcAverage.Name = "btnCalcAverage";
            this.btnCalcAverage.Size = new System.Drawing.Size(75, 43);
            this.btnCalcAverage.TabIndex = 6;
            this.btnCalcAverage.Text = "Calculate Average";
            this.btnCalcAverage.UseVisualStyleBackColor = true;
            this.btnCalcAverage.Click += new System.EventHandler(this.btnCalcAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 375);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcAverage);
            this.Controls.Add(this.tbxAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxGrade2);
            this.Controls.Add(this.tbxGrade1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Average Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGrade1;
        private System.Windows.Forms.TextBox tbxGrade2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAverage;
        private System.Windows.Forms.Button btnCalcAverage;
        private System.Windows.Forms.Button btnClear;
    }
}

