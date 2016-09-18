namespace Calculate_Fuel_Economy
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
            this.tbxMilesDriven = new System.Windows.Forms.TextBox();
            this.tbxGallonsUsed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMPG = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of miles driven:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the gallons of gas used:";
            // 
            // tbxMilesDriven
            // 
            this.tbxMilesDriven.Location = new System.Drawing.Point(228, 30);
            this.tbxMilesDriven.Name = "tbxMilesDriven";
            this.tbxMilesDriven.Size = new System.Drawing.Size(133, 22);
            this.tbxMilesDriven.TabIndex = 2;
            this.tbxMilesDriven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGallonsUsed
            // 
            this.tbxGallonsUsed.Location = new System.Drawing.Point(228, 68);
            this.tbxGallonsUsed.Name = "tbxGallonsUsed";
            this.tbxGallonsUsed.Size = new System.Drawing.Size(133, 22);
            this.tbxGallonsUsed.TabIndex = 3;
            this.tbxGallonsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your car\'s MPG:";
            // 
            // lblMPG
            // 
            this.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPG.Location = new System.Drawing.Point(228, 105);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(133, 23);
            this.lblMPG.TabIndex = 5;
            this.lblMPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 46);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculte MPG";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(184, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 46);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 210);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxGallonsUsed);
            this.Controls.Add(this.tbxMilesDriven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMilesDriven;
        private System.Windows.Forms.TextBox tbxGallonsUsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

