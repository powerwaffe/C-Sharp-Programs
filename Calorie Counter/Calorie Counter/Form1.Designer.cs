namespace Calorie_Counter
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
            this.pbBanana = new System.Windows.Forms.PictureBox();
            this.pbApple = new System.Windows.Forms.PictureBox();
            this.pbOrange = new System.Windows.Forms.PictureBox();
            this.pbPear = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCalories = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPear)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanana
            // 
            this.pbBanana.Image = global::Calorie_Counter.Properties.Resources.BananaCalories;
            this.pbBanana.Location = new System.Drawing.Point(12, 12);
            this.pbBanana.Name = "pbBanana";
            this.pbBanana.Size = new System.Drawing.Size(128, 157);
            this.pbBanana.TabIndex = 0;
            this.pbBanana.TabStop = false;
            this.pbBanana.Click += new System.EventHandler(this.pbBanana_Click);
            // 
            // pbApple
            // 
            this.pbApple.Image = global::Calorie_Counter.Properties.Resources.AppleCalories;
            this.pbApple.Location = new System.Drawing.Point(146, 12);
            this.pbApple.Name = "pbApple";
            this.pbApple.Size = new System.Drawing.Size(127, 155);
            this.pbApple.TabIndex = 1;
            this.pbApple.TabStop = false;
            this.pbApple.Click += new System.EventHandler(this.pbApple_Click);
            // 
            // pbOrange
            // 
            this.pbOrange.Image = global::Calorie_Counter.Properties.Resources.OrangeCalories;
            this.pbOrange.Location = new System.Drawing.Point(13, 175);
            this.pbOrange.Name = "pbOrange";
            this.pbOrange.Size = new System.Drawing.Size(127, 155);
            this.pbOrange.TabIndex = 2;
            this.pbOrange.TabStop = false;
            this.pbOrange.Click += new System.EventHandler(this.pbOrange_Click);
            // 
            // pbPear
            // 
            this.pbPear.Image = global::Calorie_Counter.Properties.Resources.PearCalories;
            this.pbPear.Location = new System.Drawing.Point(146, 175);
            this.pbPear.Name = "pbPear";
            this.pbPear.Size = new System.Drawing.Size(127, 156);
            this.pbPear.TabIndex = 3;
            this.pbPear.TabStop = false;
            this.pbPear.Click += new System.EventHandler(this.pbPear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Calories";
            // 
            // lbCalories
            // 
            this.lbCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCalories.Location = new System.Drawing.Point(305, 44);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(100, 23);
            this.lbCalories.TabIndex = 5;
            this.lbCalories.Text = "0";
            this.lbCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCalories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPear);
            this.Controls.Add(this.pbOrange);
            this.Controls.Add(this.pbApple);
            this.Controls.Add(this.pbBanana);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanana;
        private System.Windows.Forms.PictureBox pbApple;
        private System.Windows.Forms.PictureBox pbOrange;
        private System.Windows.Forms.PictureBox pbPear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCalories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

