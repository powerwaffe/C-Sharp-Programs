namespace List_Demo_1
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
            this.SuspendLayout();
            // 
            // lbxCities
            // 
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.Items.AddRange(new object[] {
            "Honolulu",
            "San Francisco",
            "Mississippi",
            "Mordor",
            "The Broken Isles",
            "Tamriel"});
            this.lbxCities.Location = new System.Drawing.Point(84, 69);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.Size = new System.Drawing.Size(114, 69);
            this.lbxCities.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbxCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCities;
    }
}

