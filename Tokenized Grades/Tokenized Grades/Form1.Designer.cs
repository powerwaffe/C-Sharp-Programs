namespace Tokenized_Grades
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
            this.lbxScores = new System.Windows.Forms.ListBox();
            this.btnGetScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxScores
            // 
            this.lbxScores.FormattingEnabled = true;
            this.lbxScores.ItemHeight = 16;
            this.lbxScores.Location = new System.Drawing.Point(12, 23);
            this.lbxScores.Name = "lbxScores";
            this.lbxScores.Size = new System.Drawing.Size(294, 132);
            this.lbxScores.TabIndex = 0;
            // 
            // btnGetScores
            // 
            this.btnGetScores.Location = new System.Drawing.Point(68, 193);
            this.btnGetScores.Name = "btnGetScores";
            this.btnGetScores.Size = new System.Drawing.Size(70, 42);
            this.btnGetScores.TabIndex = 1;
            this.btnGetScores.Text = "Get Scores";
            this.btnGetScores.UseVisualStyleBackColor = true;
            this.btnGetScores.Click += new System.EventHandler(this.btnGetScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(185, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetScores);
            this.Controls.Add(this.lbxScores);
            this.Name = "Form1";
            this.Text = "Grade Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxScores;
        private System.Windows.Forms.Button btnGetScores;
        private System.Windows.Forms.Button btnExit;
    }
}

