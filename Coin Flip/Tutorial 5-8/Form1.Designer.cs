namespace Tutorial_5_8
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
            this.pbxTails = new System.Windows.Forms.PictureBox();
            this.pbxHeads = new System.Windows.Forms.PictureBox();
            this.btnToss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNumOfHeads = new System.Windows.Forms.TextBox();
            this.tbxPercentOfHeads = new System.Windows.Forms.TextBox();
            this.tbxNumOfTails = new System.Windows.Forms.TextBox();
            this.tbxPercentOfTails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTails
            // 
            this.pbxTails.Image = global::Tutorial_5_8.Properties.Resources.quarter_tails;
            this.pbxTails.Location = new System.Drawing.Point(12, 38);
            this.pbxTails.Name = "pbxTails";
            this.pbxTails.Size = new System.Drawing.Size(170, 170);
            this.pbxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTails.TabIndex = 1;
            this.pbxTails.TabStop = false;
            this.pbxTails.Visible = false;
            // 
            // pbxHeads
            // 
            this.pbxHeads.Image = global::Tutorial_5_8.Properties.Resources.quarterHeads;
            this.pbxHeads.Location = new System.Drawing.Point(12, 38);
            this.pbxHeads.Name = "pbxHeads";
            this.pbxHeads.Size = new System.Drawing.Size(170, 170);
            this.pbxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHeads.TabIndex = 0;
            this.pbxHeads.TabStop = false;
            this.pbxHeads.Visible = false;
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(284, 195);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 2;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num of Heads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "% of Heads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num of Heads";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% of Tails";
            // 
            // tbxNumOfHeads
            // 
            this.tbxNumOfHeads.Location = new System.Drawing.Point(269, 35);
            this.tbxNumOfHeads.Name = "tbxNumOfHeads";
            this.tbxNumOfHeads.ReadOnly = true;
            this.tbxNumOfHeads.Size = new System.Drawing.Size(100, 20);
            this.tbxNumOfHeads.TabIndex = 7;
            // 
            // tbxPercentOfHeads
            // 
            this.tbxPercentOfHeads.Location = new System.Drawing.Point(269, 75);
            this.tbxPercentOfHeads.Name = "tbxPercentOfHeads";
            this.tbxPercentOfHeads.ReadOnly = true;
            this.tbxPercentOfHeads.Size = new System.Drawing.Size(100, 20);
            this.tbxPercentOfHeads.TabIndex = 8;
            // 
            // tbxNumOfTails
            // 
            this.tbxNumOfTails.Location = new System.Drawing.Point(269, 110);
            this.tbxNumOfTails.Name = "tbxNumOfTails";
            this.tbxNumOfTails.ReadOnly = true;
            this.tbxNumOfTails.Size = new System.Drawing.Size(100, 20);
            this.tbxNumOfTails.TabIndex = 9;
            // 
            // tbxPercentOfTails
            // 
            this.tbxPercentOfTails.Location = new System.Drawing.Point(269, 153);
            this.tbxPercentOfTails.Name = "tbxPercentOfTails";
            this.tbxPercentOfTails.ReadOnly = true;
            this.tbxPercentOfTails.Size = new System.Drawing.Size(100, 20);
            this.tbxPercentOfTails.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 242);
            this.Controls.Add(this.tbxPercentOfTails);
            this.Controls.Add(this.tbxNumOfTails);
            this.Controls.Add(this.tbxPercentOfHeads);
            this.Controls.Add(this.tbxNumOfHeads);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToss);
            this.Controls.Add(this.pbxTails);
            this.Controls.Add(this.pbxHeads);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxHeads;
        private System.Windows.Forms.PictureBox pbxTails;
        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNumOfHeads;
        private System.Windows.Forms.TextBox tbxPercentOfHeads;
        private System.Windows.Forms.TextBox tbxNumOfTails;
        private System.Windows.Forms.TextBox tbxPercentOfTails;
    }
}

