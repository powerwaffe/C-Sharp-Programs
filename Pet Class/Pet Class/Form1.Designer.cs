namespace Pet_Class
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPetName = new System.Windows.Forms.TextBox();
            this.tbxPetType = new System.Windows.Forms.TextBox();
            this.tbxPetAge = new System.Windows.Forms.TextBox();
            this.btnDisplayPet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pet Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pet Age";
            // 
            // tbxPetName
            // 
            this.tbxPetName.Location = new System.Drawing.Point(89, 52);
            this.tbxPetName.Name = "tbxPetName";
            this.tbxPetName.Size = new System.Drawing.Size(126, 22);
            this.tbxPetName.TabIndex = 3;
            // 
            // tbxPetType
            // 
            this.tbxPetType.Location = new System.Drawing.Point(89, 97);
            this.tbxPetType.Name = "tbxPetType";
            this.tbxPetType.Size = new System.Drawing.Size(126, 22);
            this.tbxPetType.TabIndex = 4;
            // 
            // tbxPetAge
            // 
            this.tbxPetAge.Location = new System.Drawing.Point(89, 141);
            this.tbxPetAge.Name = "tbxPetAge";
            this.tbxPetAge.Size = new System.Drawing.Size(126, 22);
            this.tbxPetAge.TabIndex = 5;
            // 
            // btnDisplayPet
            // 
            this.btnDisplayPet.Location = new System.Drawing.Point(12, 218);
            this.btnDisplayPet.Name = "btnDisplayPet";
            this.btnDisplayPet.Size = new System.Drawing.Size(66, 42);
            this.btnDisplayPet.TabIndex = 6;
            this.btnDisplayPet.Text = "Display Pet";
            this.btnDisplayPet.UseVisualStyleBackColor = true;
            this.btnDisplayPet.Click += new System.EventHandler(this.btnDisplayPet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(184, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearPet
            // 
            this.btnClearPet.Location = new System.Drawing.Point(99, 218);
            this.btnClearPet.Name = "btnClearPet";
            this.btnClearPet.Size = new System.Drawing.Size(66, 43);
            this.btnClearPet.TabIndex = 7;
            this.btnClearPet.Text = "Clear Pet";
            this.btnClearPet.UseVisualStyleBackColor = true;
            this.btnClearPet.Click += new System.EventHandler(this.btnClearPet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 287);
            this.Controls.Add(this.btnClearPet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayPet);
            this.Controls.Add(this.tbxPetAge);
            this.Controls.Add(this.tbxPetType);
            this.Controls.Add(this.tbxPetName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pet Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPetName;
        private System.Windows.Forms.TextBox tbxPetType;
        private System.Windows.Forms.TextBox tbxPetAge;
        private System.Windows.Forms.Button btnDisplayPet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearPet;
    }
}

