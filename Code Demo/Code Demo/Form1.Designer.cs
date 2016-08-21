namespace Code_Demo
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
            this.firstButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(50, 54);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(101, 39);
            this.firstButton.TabIndex = 1;
            this.firstButton.Text = "First Button";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Location = new System.Drawing.Point(300, 54);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(103, 39);
            this.thirdButton.TabIndex = 2;
            this.thirdButton.Text = "Third Button";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.thirdButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(169, 54);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(112, 39);
            this.secondButton.TabIndex = 3;
            this.secondButton.Text = "Second Button";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 135);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.firstButton);
            this.Name = "Form1";
            this.Text = "Code Demo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button thirdButton;
        private System.Windows.Forms.Button secondButton;
    }
}

