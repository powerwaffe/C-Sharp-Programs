namespace Payment_Calculator
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
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHourlyPayRate = new System.Windows.Forms.TextBox();
            this.btnCalculateGrossPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCalculatedGrossPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours Worked";
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(186, 44);
            this.tbHoursWorked.Margin = new System.Windows.Forms.Padding(4);
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(132, 22);
            this.tbHoursWorked.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hourly Pay Rate";
            // 
            // tbHourlyPayRate
            // 
            this.tbHourlyPayRate.Location = new System.Drawing.Point(186, 91);
            this.tbHourlyPayRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbHourlyPayRate.Name = "tbHourlyPayRate";
            this.tbHourlyPayRate.Size = new System.Drawing.Size(132, 22);
            this.tbHourlyPayRate.TabIndex = 3;
            // 
            // btnCalculateGrossPay
            // 
            this.btnCalculateGrossPay.Location = new System.Drawing.Point(40, 183);
            this.btnCalculateGrossPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateGrossPay.Name = "btnCalculateGrossPay";
            this.btnCalculateGrossPay.Size = new System.Drawing.Size(95, 47);
            this.btnCalculateGrossPay.TabIndex = 4;
            this.btnCalculateGrossPay.Text = "Calculate Gross Pay";
            this.btnCalculateGrossPay.UseVisualStyleBackColor = true;
            this.btnCalculateGrossPay.Click += new System.EventHandler(this.btnCalculateGrossPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(243, 183);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 47);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calculated Gross Pay";
            // 
            // tbCalculatedGrossPay
            // 
            this.tbCalculatedGrossPay.Location = new System.Drawing.Point(186, 134);
            this.tbCalculatedGrossPay.Name = "tbCalculatedGrossPay";
            this.tbCalculatedGrossPay.ReadOnly = true;
            this.tbCalculatedGrossPay.Size = new System.Drawing.Size(132, 22);
            this.tbCalculatedGrossPay.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 287);
            this.Controls.Add(this.tbCalculatedGrossPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateGrossPay);
            this.Controls.Add(this.tbHourlyPayRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Payroll Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHourlyPayRate;
        private System.Windows.Forms.Button btnCalculateGrossPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCalculatedGrossPay;
    }
}

