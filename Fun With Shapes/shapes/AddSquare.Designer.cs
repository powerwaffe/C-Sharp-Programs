namespace shapes
{
    partial class AddSquare
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSide1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 39);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add Shape";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerimeter.Location = new System.Drawing.Point(92, 118);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(133, 28);
            this.lblPerimeter.TabIndex = 20;
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-1, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Perimeter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Location = new System.Drawing.Point(92, 71);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(133, 28);
            this.lblArea.TabIndex = 18;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-1, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxSide1
            // 
            this.tbxSide1.Location = new System.Drawing.Point(70, 30);
            this.tbxSide1.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSide1.Name = "tbxSide1";
            this.tbxSide1.Size = new System.Drawing.Size(132, 22);
            this.tbxSide1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Side 1";
            // 
            // AddSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 344);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSide1);
            this.Controls.Add(this.label1);
            this.Name = "AddSquare";
            this.Text = "Add Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSide1;
        private System.Windows.Forms.Label label1;
    }
}