namespace Ice_Cream
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
            this.lblFlavors = new System.Windows.Forms.Label();
            this.lbxFlavors = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFlavors
            // 
            this.lblFlavors.AutoSize = true;
            this.lblFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavors.Location = new System.Drawing.Point(12, 21);
            this.lblFlavors.Name = "lblFlavors";
            this.lblFlavors.Size = new System.Drawing.Size(154, 20);
            this.lblFlavors.TabIndex = 0;
            this.lblFlavors.Text = "Ice Cream Flavors";
            // 
            // lbxFlavors
            // 
            this.lbxFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFlavors.FormattingEnabled = true;
            this.lbxFlavors.ItemHeight = 16;
            this.lbxFlavors.Location = new System.Drawing.Point(12, 49);
            this.lbxFlavors.Name = "lbxFlavors";
            this.lbxFlavors.Size = new System.Drawing.Size(160, 84);
            this.lbxFlavors.TabIndex = 1;
            this.lbxFlavors.SelectedIndexChanged += new System.EventHandler(this.lbxFlavors_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AllowDrop = true;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(12, 156);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(260, 18);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbxFlavors);
            this.Controls.Add(this.lblFlavors);
            this.Name = "Form1";
            this.Text = "Ice Cream Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlavors;
        private System.Windows.Forms.ListBox lbxFlavors;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplay;
    }
}

