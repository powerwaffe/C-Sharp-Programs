namespace Exam1_Ticket_Sales
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
            this.tbxBaseTicketPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDecrementAdult = new System.Windows.Forms.Button();
            this.tbxAdultTicketCount = new System.Windows.Forms.TextBox();
            this.btnIncrementAdult = new System.Windows.Forms.Button();
            this.tbxDisplayAdultBase = new System.Windows.Forms.TextBox();
            this.btnDecrementChild = new System.Windows.Forms.Button();
            this.btnIncrementChild = new System.Windows.Forms.Button();
            this.tbxChildTicketCount = new System.Windows.Forms.TextBox();
            this.tbxDisplayChildBase = new System.Windows.Forms.TextBox();
            this.btnDecrementSenior = new System.Windows.Forms.Button();
            this.tbxSeniorTicketCount = new System.Windows.Forms.TextBox();
            this.btnIncrementSenior = new System.Windows.Forms.Button();
            this.tbxDisplaySeniorBase = new System.Windows.Forms.TextBox();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.tbxTaxedSubtotal = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Ticket Price";
            // 
            // tbxBaseTicketPrice
            // 
            this.tbxBaseTicketPrice.Location = new System.Drawing.Point(200, 33);
            this.tbxBaseTicketPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBaseTicketPrice.Name = "tbxBaseTicketPrice";
            this.tbxBaseTicketPrice.Size = new System.Drawing.Size(132, 22);
            this.tbxBaseTicketPrice.TabIndex = 1;
            this.tbxBaseTicketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adult (Base)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Child (50% Discount)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senior (25% Discount)";
            // 
            // btnDecrementAdult
            // 
            this.btnDecrementAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementAdult.Location = new System.Drawing.Point(239, 69);
            this.btnDecrementAdult.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrementAdult.Name = "btnDecrementAdult";
            this.btnDecrementAdult.Size = new System.Drawing.Size(49, 41);
            this.btnDecrementAdult.TabIndex = 5;
            this.btnDecrementAdult.Text = "-";
            this.btnDecrementAdult.UseVisualStyleBackColor = true;
            this.btnDecrementAdult.Click += new System.EventHandler(this.btnDecrementAdult_Click);
            // 
            // tbxAdultTicketCount
            // 
            this.tbxAdultTicketCount.Enabled = false;
            this.tbxAdultTicketCount.Location = new System.Drawing.Point(298, 80);
            this.tbxAdultTicketCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAdultTicketCount.Name = "tbxAdultTicketCount";
            this.tbxAdultTicketCount.Size = new System.Drawing.Size(35, 22);
            this.tbxAdultTicketCount.TabIndex = 6;
            this.tbxAdultTicketCount.Text = "0";
            this.tbxAdultTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIncrementAdult
            // 
            this.btnIncrementAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementAdult.Location = new System.Drawing.Point(341, 69);
            this.btnIncrementAdult.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncrementAdult.Name = "btnIncrementAdult";
            this.btnIncrementAdult.Size = new System.Drawing.Size(48, 42);
            this.btnIncrementAdult.TabIndex = 7;
            this.btnIncrementAdult.Text = "+";
            this.btnIncrementAdult.UseVisualStyleBackColor = true;
            this.btnIncrementAdult.Click += new System.EventHandler(this.btnIncrementAdult_Click);
            // 
            // tbxDisplayAdultBase
            // 
            this.tbxDisplayAdultBase.Enabled = false;
            this.tbxDisplayAdultBase.Location = new System.Drawing.Point(432, 78);
            this.tbxDisplayAdultBase.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDisplayAdultBase.Name = "tbxDisplayAdultBase";
            this.tbxDisplayAdultBase.Size = new System.Drawing.Size(132, 22);
            this.tbxDisplayAdultBase.TabIndex = 8;
            this.tbxDisplayAdultBase.Text = "0";
            this.tbxDisplayAdultBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDecrementChild
            // 
            this.btnDecrementChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementChild.Location = new System.Drawing.Point(239, 122);
            this.btnDecrementChild.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrementChild.Name = "btnDecrementChild";
            this.btnDecrementChild.Size = new System.Drawing.Size(49, 42);
            this.btnDecrementChild.TabIndex = 9;
            this.btnDecrementChild.Text = "-";
            this.btnDecrementChild.UseVisualStyleBackColor = true;
            this.btnDecrementChild.Click += new System.EventHandler(this.btnDecrementChild_Click);
            // 
            // btnIncrementChild
            // 
            this.btnIncrementChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementChild.Location = new System.Drawing.Point(341, 122);
            this.btnIncrementChild.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncrementChild.Name = "btnIncrementChild";
            this.btnIncrementChild.Size = new System.Drawing.Size(49, 42);
            this.btnIncrementChild.TabIndex = 10;
            this.btnIncrementChild.Text = "+";
            this.btnIncrementChild.UseVisualStyleBackColor = true;
            this.btnIncrementChild.Click += new System.EventHandler(this.btnIncrementChild_Click);
            // 
            // tbxChildTicketCount
            // 
            this.tbxChildTicketCount.Enabled = false;
            this.tbxChildTicketCount.Location = new System.Drawing.Point(296, 132);
            this.tbxChildTicketCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxChildTicketCount.Name = "tbxChildTicketCount";
            this.tbxChildTicketCount.Size = new System.Drawing.Size(36, 22);
            this.tbxChildTicketCount.TabIndex = 11;
            this.tbxChildTicketCount.Text = "0";
            this.tbxChildTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDisplayChildBase
            // 
            this.tbxDisplayChildBase.Enabled = false;
            this.tbxDisplayChildBase.Location = new System.Drawing.Point(432, 132);
            this.tbxDisplayChildBase.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDisplayChildBase.Name = "tbxDisplayChildBase";
            this.tbxDisplayChildBase.Size = new System.Drawing.Size(132, 22);
            this.tbxDisplayChildBase.TabIndex = 12;
            this.tbxDisplayChildBase.Text = "0";
            this.tbxDisplayChildBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDecrementSenior
            // 
            this.btnDecrementSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementSenior.Location = new System.Drawing.Point(239, 173);
            this.btnDecrementSenior.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrementSenior.Name = "btnDecrementSenior";
            this.btnDecrementSenior.Size = new System.Drawing.Size(49, 42);
            this.btnDecrementSenior.TabIndex = 13;
            this.btnDecrementSenior.Text = "-";
            this.btnDecrementSenior.UseVisualStyleBackColor = true;
            this.btnDecrementSenior.Click += new System.EventHandler(this.btnDecrementSenior_Click);
            // 
            // tbxSeniorTicketCount
            // 
            this.tbxSeniorTicketCount.Enabled = false;
            this.tbxSeniorTicketCount.Location = new System.Drawing.Point(296, 182);
            this.tbxSeniorTicketCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSeniorTicketCount.Name = "tbxSeniorTicketCount";
            this.tbxSeniorTicketCount.Size = new System.Drawing.Size(36, 22);
            this.tbxSeniorTicketCount.TabIndex = 14;
            this.tbxSeniorTicketCount.Text = "0";
            this.tbxSeniorTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIncrementSenior
            // 
            this.btnIncrementSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementSenior.Location = new System.Drawing.Point(340, 174);
            this.btnIncrementSenior.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncrementSenior.Name = "btnIncrementSenior";
            this.btnIncrementSenior.Size = new System.Drawing.Size(49, 41);
            this.btnIncrementSenior.TabIndex = 15;
            this.btnIncrementSenior.Text = "+";
            this.btnIncrementSenior.UseVisualStyleBackColor = true;
            this.btnIncrementSenior.Click += new System.EventHandler(this.btnIncrementSenior_Click);
            // 
            // tbxDisplaySeniorBase
            // 
            this.tbxDisplaySeniorBase.Enabled = false;
            this.tbxDisplaySeniorBase.Location = new System.Drawing.Point(432, 182);
            this.tbxDisplaySeniorBase.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDisplaySeniorBase.Name = "tbxDisplaySeniorBase";
            this.tbxDisplaySeniorBase.Size = new System.Drawing.Size(132, 22);
            this.tbxDisplaySeniorBase.TabIndex = 16;
            this.tbxDisplaySeniorBase.Text = "0";
            this.tbxDisplaySeniorBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Enabled = false;
            this.tbxSubtotal.Location = new System.Drawing.Point(432, 231);
            this.tbxSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.Size = new System.Drawing.Size(132, 22);
            this.tbxSubtotal.TabIndex = 17;
            this.tbxSubtotal.Text = "0";
            this.tbxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTaxedSubtotal
            // 
            this.tbxTaxedSubtotal.Enabled = false;
            this.tbxTaxedSubtotal.Location = new System.Drawing.Point(432, 277);
            this.tbxTaxedSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTaxedSubtotal.Name = "tbxTaxedSubtotal";
            this.tbxTaxedSubtotal.Size = new System.Drawing.Size(132, 22);
            this.tbxTaxedSubtotal.TabIndex = 18;
            this.tbxTaxedSubtotal.Text = "0";
            this.tbxTaxedSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(432, 321);
            this.tbxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(132, 22);
            this.tbxTotal.TabIndex = 19;
            this.tbxTotal.Text = "0";
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tax (6%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 356);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 44);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(220, 356);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 44);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 415);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxTaxedSubtotal);
            this.Controls.Add(this.tbxSubtotal);
            this.Controls.Add(this.tbxDisplaySeniorBase);
            this.Controls.Add(this.btnIncrementSenior);
            this.Controls.Add(this.tbxSeniorTicketCount);
            this.Controls.Add(this.btnDecrementSenior);
            this.Controls.Add(this.tbxDisplayChildBase);
            this.Controls.Add(this.tbxChildTicketCount);
            this.Controls.Add(this.btnIncrementChild);
            this.Controls.Add(this.btnDecrementChild);
            this.Controls.Add(this.tbxDisplayAdultBase);
            this.Controls.Add(this.btnIncrementAdult);
            this.Controls.Add(this.tbxAdultTicketCount);
            this.Controls.Add(this.btnDecrementAdult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBaseTicketPrice);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Chiller Theater Ticket Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBaseTicketPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecrementAdult;
        private System.Windows.Forms.TextBox tbxAdultTicketCount;
        private System.Windows.Forms.Button btnIncrementAdult;
        private System.Windows.Forms.TextBox tbxDisplayAdultBase;
        private System.Windows.Forms.Button btnDecrementChild;
        private System.Windows.Forms.Button btnIncrementChild;
        private System.Windows.Forms.TextBox tbxChildTicketCount;
        private System.Windows.Forms.TextBox tbxDisplayChildBase;
        private System.Windows.Forms.Button btnDecrementSenior;
        private System.Windows.Forms.TextBox tbxSeniorTicketCount;
        private System.Windows.Forms.Button btnIncrementSenior;
        private System.Windows.Forms.TextBox tbxDisplaySeniorBase;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.TextBox tbxTaxedSubtotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

