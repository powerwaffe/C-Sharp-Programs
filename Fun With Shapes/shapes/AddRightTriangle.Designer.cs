namespace shapes
{
    partial class AddRightTriangle
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
            this.tbxSide1 = new System.Windows.Forms.TextBox();
            this.tbxSide2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side 1";
            // 
            // tbxSide1
            // 
            this.tbxSide1.Location = new System.Drawing.Point(57, 13);
            this.tbxSide1.Name = "tbxSide1";
            this.tbxSide1.Size = new System.Drawing.Size(100, 20);
            this.tbxSide1.TabIndex = 1;
            // 
            // tbxSide2
            // 
            this.tbxSide2.Location = new System.Drawing.Point(57, 39);
            this.tbxSide2.Name = "tbxSide2";
            this.tbxSide2.Size = new System.Drawing.Size(100, 20);
            this.tbxSide2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Side 2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hypotenuse";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHypotenuse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHypotenuse.Location = new System.Drawing.Point(85, 79);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(100, 23);
            this.lblHypotenuse.TabIndex = 5;
            this.lblHypotenuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Location = new System.Drawing.Point(85, 117);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 23);
            this.lblArea.TabIndex = 7;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerimeter.Location = new System.Drawing.Point(85, 155);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(100, 23);
            this.lblPerimeter.TabIndex = 9;
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Perimeter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Shape";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddRightTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSide1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRightTriangle";
            this.Text = "Add Right Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSide1;
        private System.Windows.Forms.TextBox tbxSide2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHypotenuse;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
    }
}