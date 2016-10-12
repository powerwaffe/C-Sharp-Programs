namespace Account_Maintenance
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
            this.lbxAccountList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxAccountToAdd = new System.Windows.Forms.TextBox();
            this.tbxAccountToDelete = new System.Windows.Forms.TextBox();
            this.tbxAccountToVerify = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxAccountList
            // 
            this.lbxAccountList.FormattingEnabled = true;
            this.lbxAccountList.ItemHeight = 16;
            this.lbxAccountList.Location = new System.Drawing.Point(16, 59);
            this.lbxAccountList.Margin = new System.Windows.Forms.Padding(4);
            this.lbxAccountList.Name = "lbxAccountList";
            this.lbxAccountList.Size = new System.Drawing.Size(133, 228);
            this.lbxAccountList.Sorted = true;
            this.lbxAccountList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account List";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 59);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Account";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(168, 111);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 49);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify Account";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 168);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 304);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 225);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear All Accounts";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxAccountToAdd
            // 
            this.tbxAccountToAdd.Location = new System.Drawing.Point(285, 70);
            this.tbxAccountToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAccountToAdd.MaxLength = 5;
            this.tbxAccountToAdd.Name = "tbxAccountToAdd";
            this.tbxAccountToAdd.Size = new System.Drawing.Size(78, 22);
            this.tbxAccountToAdd.TabIndex = 7;
            this.tbxAccountToAdd.Text = "0";
            // 
            // tbxAccountToDelete
            // 
            this.tbxAccountToDelete.Location = new System.Drawing.Point(284, 181);
            this.tbxAccountToDelete.MaxLength = 5;
            this.tbxAccountToDelete.Name = "tbxAccountToDelete";
            this.tbxAccountToDelete.Size = new System.Drawing.Size(78, 22);
            this.tbxAccountToDelete.TabIndex = 8;
            this.tbxAccountToDelete.Text = "0";
            // 
            // tbxAccountToVerify
            // 
            this.tbxAccountToVerify.Location = new System.Drawing.Point(285, 124);
            this.tbxAccountToVerify.MaxLength = 5;
            this.tbxAccountToVerify.Name = "tbxAccountToVerify";
            this.tbxAccountToVerify.Size = new System.Drawing.Size(77, 22);
            this.tbxAccountToVerify.TabIndex = 9;
            this.tbxAccountToVerify.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 389);
            this.ControlBox = false;
            this.Controls.Add(this.tbxAccountToVerify);
            this.Controls.Add(this.tbxAccountToDelete);
            this.Controls.Add(this.tbxAccountToAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAccountList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Account Maintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAccountList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxAccountToAdd;
        private System.Windows.Forms.TextBox tbxAccountToDelete;
        private System.Windows.Forms.TextBox tbxAccountToVerify;
    }
}

