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
            this.cdDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbDropDown
            // 
            this.cbDropDown.FormattingEnabled = true;
            this.cbDropDown.Items.AddRange(new object[] {
            "You can click me!",
            "You can Type in me.",
            "You can select me!"});
            this.cbDropDown.Location = new System.Drawing.Point(12, 51);
            this.cbDropDown.Name = "cbDropDown";
            this.cbDropDown.Size = new System.Drawing.Size(159, 21);
            this.cbDropDown.TabIndex = 0;
            this.cbDropDown.SelectedIndexChanged += new System.EventHandler(this.cbDropDown_SelectedIndexChanged);
            // 
            // cbDropDownSimple
            // 
            this.cbDropDownSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDropDownSimple.FormattingEnabled = true;
            this.cbDropDownSimple.Items.AddRange(new object[] {
            "I always show!",
            "You can type in this box."});
            this.cbDropDownSimple.Location = new System.Drawing.Point(177, 51);
            this.cbDropDownSimple.MaxDropDownItems = 4;
            this.cbDropDownSimple.Name = "cbDropDownSimple";
            this.cbDropDownSimple.Size = new System.Drawing.Size(159, 98);
            this.cbDropDownSimple.TabIndex = 1;
            // 
            // cdDropDownList
            // 
            this.cdDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdDropDownList.FormattingEnabled = true;
            this.cdDropDownList.Items.AddRange(new object[] {
            "You may only select from me."});
            this.cdDropDownList.Location = new System.Drawing.Point(342, 51);
            this.cdDropDownList.Name = "cdDropDownList";
            this.cdDropDownList.Size = new System.Drawing.Size(159, 21);
            this.cdDropDownList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 182);
            this.Controls.Add(this.cdDropDownList);
            this.Controls.Add(this.cbDropDownSimple);
            this.Controls.Add(this.cbDropDown);
            this.Name = "Form1";
            this.Text = "Combo Box Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDropDown;
        private System.Windows.Forms.ComboBox cbDropDownSimple;
        private System.Windows.Forms.ComboBox cdDropDownList;
    }
}

