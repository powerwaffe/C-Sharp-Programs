namespace Time_Zone_Form
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
            this.lbxCities = new System.Windows.Forms.ListBox();
            this.lbSelectedCity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCities
            // 
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.lbxCities.Location = new System.Drawing.Point(75, 91);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.Size = new System.Drawing.Size(113, 56);
            this.lbxCities.TabIndex = 0;
            this.lbxCities.SelectedIndexChanged += new System.EventHandler(this.lbxCities_SelectedIndexChanged);
            // 
            // lbSelectedCity
            // 
            this.lbSelectedCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelectedCity.Location = new System.Drawing.Point(72, 165);
            this.lbSelectedCity.Name = "lbSelectedCity";
            this.lbSelectedCity.Size = new System.Drawing.Size(116, 21);
            this.lbSelectedCity.TabIndex = 1;
            this.lbSelectedCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Zone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a caity and I will Give you the time zone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSelectedCity);
            this.Controls.Add(this.lbxCities);
            this.Name = "Form1";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCities;
        private System.Windows.Forms.Label lbSelectedCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

