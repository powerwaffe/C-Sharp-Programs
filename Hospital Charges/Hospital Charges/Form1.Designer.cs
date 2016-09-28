namespace Hospital_Charges
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
            this.tbxDaysSpentInHospital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMedicalCharges = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSurgicalCharges = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLabFees = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRehabilitationCharges = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days Spent in Hospital ($350 A DAY):";
            // 
            // tbxDaysSpentInHospital
            // 
            this.tbxDaysSpentInHospital.Location = new System.Drawing.Point(265, 37);
            this.tbxDaysSpentInHospital.Name = "tbxDaysSpentInHospital";
            this.tbxDaysSpentInHospital.Size = new System.Drawing.Size(151, 22);
            this.tbxDaysSpentInHospital.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medical Charges:";
            // 
            // tbxMedicalCharges
            // 
            this.tbxMedicalCharges.Location = new System.Drawing.Point(265, 71);
            this.tbxMedicalCharges.Name = "tbxMedicalCharges";
            this.tbxMedicalCharges.Size = new System.Drawing.Size(151, 22);
            this.tbxMedicalCharges.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surgical Charges:";
            // 
            // tbxSurgicalCharges
            // 
            this.tbxSurgicalCharges.Location = new System.Drawing.Point(265, 109);
            this.tbxSurgicalCharges.Name = "tbxSurgicalCharges";
            this.tbxSurgicalCharges.Size = new System.Drawing.Size(151, 22);
            this.tbxSurgicalCharges.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lab Fees:";
            // 
            // tbxLabFees
            // 
            this.tbxLabFees.Location = new System.Drawing.Point(265, 150);
            this.tbxLabFees.Name = "tbxLabFees";
            this.tbxLabFees.Size = new System.Drawing.Size(151, 22);
            this.tbxLabFees.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Physical Rehabilitation Charges:";
            // 
            // tbxRehabilitationCharges
            // 
            this.tbxRehabilitationCharges.Location = new System.Drawing.Point(265, 187);
            this.tbxRehabilitationCharges.Name = "tbxRehabilitationCharges";
            this.tbxRehabilitationCharges.Size = new System.Drawing.Size(151, 22);
            this.tbxRehabilitationCharges.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Charges:";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(265, 262);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(151, 22);
            this.tbxTotal.TabIndex = 11;
            this.tbxTotal.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(65, 328);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 44);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 44);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(271, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 392);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxRehabilitationCharges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxLabFees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSurgicalCharges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMedicalCharges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDaysSpentInHospital);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDaysSpentInHospital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMedicalCharges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSurgicalCharges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLabFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRehabilitationCharges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

