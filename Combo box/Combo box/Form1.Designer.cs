namespace Combo_box
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
            this.cbDropDown = new System.Windows.Forms.ComboBox();
            this.cbDropDownSimple = new System.Windows.Forms.ComboBox();
            this.cbDropDownList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDropDown
            // 
            this.cbDropDown.FormattingEnabled = true;
            this.cbDropDown.Items.AddRange(new object[] {
            "You can Type in me.",
            "You can select me!",
            "Apples",
            "Steak",
            "More Food"});
            this.cbDropDown.Location = new System.Drawing.Point(4, 62);
            this.cbDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropDown.Name = "cbDropDown";
            this.cbDropDown.Size = new System.Drawing.Size(211, 24);
            this.cbDropDown.TabIndex = 0;
            this.cbDropDown.SelectedIndexChanged += new System.EventHandler(this.cbDropDown_SelectedIndexChanged);
            // 
            // cbDropDownSimple
            // 
            this.cbDropDownSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDropDownSimple.FormattingEnabled = true;
            this.cbDropDownSimple.Items.AddRange(new object[] {
            "I always show!",
            "You can type in this box.",
            "You can select items from this box."});
            this.cbDropDownSimple.Location = new System.Drawing.Point(223, 62);
            this.cbDropDownSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropDownSimple.MaxDropDownItems = 4;
            this.cbDropDownSimple.Name = "cbDropDownSimple";
            this.cbDropDownSimple.Size = new System.Drawing.Size(211, 120);
            this.cbDropDownSimple.TabIndex = 1;
            this.cbDropDownSimple.SelectedIndexChanged += new System.EventHandler(this.cbDropDownSimple_SelectedIndexChanged);
            // 
            // cbDropDownList
            // 
            this.cbDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDropDownList.FormattingEnabled = true;
            this.cbDropDownList.Items.AddRange(new object[] {
            "You may only select from me.",
            "George",
            "Jerry",
            "Elaine",
            "Kramer"});
            this.cbDropDownList.Location = new System.Drawing.Point(442, 62);
            this.cbDropDownList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropDownList.Name = "cbDropDownList";
            this.cbDropDownList.Size = new System.Drawing.Size(211, 24);
            this.cbDropDownList.TabIndex = 2;
            this.cbDropDownList.SelectedIndexChanged += new System.EventHandler(this.cbDropDownList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drop-Down Combo Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Simple Combo Box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drop-Down List Combo Box";
            // 
            // lbDisplay
            // 
            this.lbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(144, 229);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(341, 27);
            this.lbDisplay.TabIndex = 6;
            this.lbDisplay.Text = "Select An Item";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 265);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDropDownList);
            this.Controls.Add(this.cbDropDownSimple);
            this.Controls.Add(this.cbDropDown);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Combo Box Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDropDown;
        private System.Windows.Forms.ComboBox cbDropDownSimple;
        private System.Windows.Forms.ComboBox cbDropDownList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDisplay;
    }
}

