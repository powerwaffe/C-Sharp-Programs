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
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTails
            // 
            this.pbxTails.Image = global::Tutorial_5_8.Properties.Resources.quarter_tails;
            this.pbxTails.Location = new System.Drawing.Point(81, 100);
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
            this.pbxHeads.Location = new System.Drawing.Point(81, 100);
            this.pbxHeads.Name = "pbxHeads";
            this.pbxHeads.Size = new System.Drawing.Size(170, 170);
            this.pbxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHeads.TabIndex = 0;
            this.pbxHeads.TabStop = false;
            this.pbxHeads.Visible = false;
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(130, 48);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 2;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 282);
            this.Controls.Add(this.btnToss);
            this.Controls.Add(this.pbxTails);
            this.Controls.Add(this.pbxHeads);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxHeads;
        private System.Windows.Forms.PictureBox pbxTails;
        private System.Windows.Forms.Button btnToss;
    }
}

