namespace Dorm_and_Meal_Plan_Calculator
{
    partial class frmDormAndMealPlans
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtAllenHall = new System.Windows.Forms.RadioButton();
            this.rbtPikeHall = new System.Windows.Forms.RadioButton();
            this.rbtFarthingHall = new System.Windows.Forms.RadioButton();
            this.rbtUniversitySuite = new System.Windows.Forms.RadioButton();
            this.rbt7MealsPerWeek = new System.Windows.Forms.RadioButton();
            this.rbt14MealsPerWeek = new System.Windows.Forms.RadioButton();
            this.rbtUnlimitedMeals = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtUniversitySuite);
            this.groupBox1.Controls.Add(this.rbtFarthingHall);
            this.groupBox1.Controls.Add(this.rbtPikeHall);
            this.groupBox1.Controls.Add(this.rbtAllenHall);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dormitories";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbtUnlimitedMeals);
            this.groupBox2.Controls.Add(this.rbt14MealsPerWeek);
            this.groupBox2.Controls.Add(this.rbt7MealsPerWeek);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal Plans";
            // 
            // rbtAllenHall
            // 
            this.rbtAllenHall.AutoSize = true;
            this.rbtAllenHall.Location = new System.Drawing.Point(7, 20);
            this.rbtAllenHall.Name = "rbtAllenHall";
            this.rbtAllenHall.Size = new System.Drawing.Size(67, 17);
            this.rbtAllenHall.TabIndex = 0;
            this.rbtAllenHall.TabStop = true;
            this.rbtAllenHall.Text = "Allen hall";
            this.rbtAllenHall.UseVisualStyleBackColor = true;
            this.rbtAllenHall.CheckedChanged += new System.EventHandler(this.Dormitories_CheckedChanged);
            // 
            // rbtPikeHall
            // 
            this.rbtPikeHall.AutoSize = true;
            this.rbtPikeHall.Location = new System.Drawing.Point(7, 44);
            this.rbtPikeHall.Name = "rbtPikeHall";
            this.rbtPikeHall.Size = new System.Drawing.Size(67, 17);
            this.rbtPikeHall.TabIndex = 1;
            this.rbtPikeHall.TabStop = true;
            this.rbtPikeHall.Text = "Pike Hall";
            this.rbtPikeHall.UseVisualStyleBackColor = true;
            this.rbtPikeHall.CheckedChanged += new System.EventHandler(this.Dormitories_CheckedChanged);
            // 
            // rbtFarthingHall
            // 
            this.rbtFarthingHall.AutoSize = true;
            this.rbtFarthingHall.Location = new System.Drawing.Point(6, 67);
            this.rbtFarthingHall.Name = "rbtFarthingHall";
            this.rbtFarthingHall.Size = new System.Drawing.Size(84, 17);
            this.rbtFarthingHall.TabIndex = 2;
            this.rbtFarthingHall.TabStop = true;
            this.rbtFarthingHall.Text = "Farthing Hall";
            this.rbtFarthingHall.UseVisualStyleBackColor = true;
            this.rbtFarthingHall.CheckedChanged += new System.EventHandler(this.Dormitories_CheckedChanged);
            // 
            // rbtUniversitySuite
            // 
            this.rbtUniversitySuite.AutoSize = true;
            this.rbtUniversitySuite.Location = new System.Drawing.Point(7, 90);
            this.rbtUniversitySuite.Name = "rbtUniversitySuite";
            this.rbtUniversitySuite.Size = new System.Drawing.Size(103, 17);
            this.rbtUniversitySuite.TabIndex = 3;
            this.rbtUniversitySuite.TabStop = true;
            this.rbtUniversitySuite.Text = "University Suites";
            this.rbtUniversitySuite.UseVisualStyleBackColor = true;
            this.rbtUniversitySuite.CheckedChanged += new System.EventHandler(this.Dormitories_CheckedChanged);
            // 
            // rbt7MealsPerWeek
            // 
            this.rbt7MealsPerWeek.AutoSize = true;
            this.rbt7MealsPerWeek.Location = new System.Drawing.Point(7, 20);
            this.rbt7MealsPerWeek.Name = "rbt7MealsPerWeek";
            this.rbt7MealsPerWeek.Size = new System.Drawing.Size(113, 17);
            this.rbt7MealsPerWeek.TabIndex = 0;
            this.rbt7MealsPerWeek.TabStop = true;
            this.rbt7MealsPerWeek.Text = "7 Meals Per Week";
            this.rbt7MealsPerWeek.UseVisualStyleBackColor = true;
            // 
            // rbt14MealsPerWeek
            // 
            this.rbt14MealsPerWeek.AutoSize = true;
            this.rbt14MealsPerWeek.Location = new System.Drawing.Point(7, 44);
            this.rbt14MealsPerWeek.Name = "rbt14MealsPerWeek";
            this.rbt14MealsPerWeek.Size = new System.Drawing.Size(119, 17);
            this.rbt14MealsPerWeek.TabIndex = 1;
            this.rbt14MealsPerWeek.TabStop = true;
            this.rbt14MealsPerWeek.Text = "14 Meals Per Week";
            this.rbt14MealsPerWeek.UseVisualStyleBackColor = true;
            // 
            // rbtUnlimitedMeals
            // 
            this.rbtUnlimitedMeals.AutoSize = true;
            this.rbtUnlimitedMeals.Location = new System.Drawing.Point(7, 68);
            this.rbtUnlimitedMeals.Name = "rbtUnlimitedMeals";
            this.rbtUnlimitedMeals.Size = new System.Drawing.Size(99, 17);
            this.rbtUnlimitedMeals.TabIndex = 2;
            this.rbtUnlimitedMeals.TabStop = true;
            this.rbtUnlimitedMeals.Text = "Unlimited Meals";
            this.rbtUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "$1,500 per semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "$1,600 per semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "$1,800 per semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "$2,500 per semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "$600 per semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "$1,200 per semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "$1,700 per semester";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(43, 279);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(75, 34);
            this.btnCalculateTotal.TabIndex = 2;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // frmDormAndMealPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 344);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDormAndMealPlans";
            this.Text = "Dorm and Meal Plans";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtUniversitySuite;
        private System.Windows.Forms.RadioButton rbtFarthingHall;
        private System.Windows.Forms.RadioButton rbtPikeHall;
        private System.Windows.Forms.RadioButton rbtAllenHall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtUnlimitedMeals;
        private System.Windows.Forms.RadioButton rbt14MealsPerWeek;
        private System.Windows.Forms.RadioButton rbt7MealsPerWeek;
        private System.Windows.Forms.Button btnCalculateTotal;
    }
}

