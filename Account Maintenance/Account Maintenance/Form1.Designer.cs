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
            this.SuspendLayout();
            // 
            // lbxAccountList
            // 
            this.lbxAccountList.FormattingEnabled = true;
            this.lbxAccountList.Location = new System.Drawing.Point(12, 48);
            this.lbxAccountList.Name = "lbxAccountList";
            this.lbxAccountList.Size = new System.Drawing.Size(145, 186);
            this.lbxAccountList.Sorted = true;
            this.lbxAccountList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account List";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Account";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(199, 90);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 40);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify Account";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(199, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tbxAccountToAdd
            // 
            this.tbxAccountToAdd.Location = new System.Drawing.Point(280, 57);
            this.tbxAccountToAdd.Name = "tbxAccountToAdd";
            this.tbxAccountToAdd.Size = new System.Drawing.Size(115, 20);
            this.tbxAccountToAdd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 316);
            this.Controls.Add(this.tbxAccountToAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAccountList);
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
    }
}

