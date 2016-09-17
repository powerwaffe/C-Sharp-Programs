namespace Lights
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
            this.pbxLightOn = new System.Windows.Forms.PictureBox();
            this.pbxLightOff = new System.Windows.Forms.PictureBox();
            this.lblLightState = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightOff)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLightOn
            // 
            this.pbxLightOn.Image = global::Lights.Properties.Resources.lightOn1;
            this.pbxLightOn.Location = new System.Drawing.Point(32, 88);
            this.pbxLightOn.Name = "pbxLightOn";
            this.pbxLightOn.Size = new System.Drawing.Size(281, 180);
            this.pbxLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightOn.TabIndex = 0;
            this.pbxLightOn.TabStop = false;
            // 
            // pbxLightOff
            // 
            this.pbxLightOff.Image = global::Lights.Properties.Resources.lightOff1;
            this.pbxLightOff.Location = new System.Drawing.Point(32, 88);
            this.pbxLightOff.Name = "pbxLightOff";
            this.pbxLightOff.Size = new System.Drawing.Size(281, 180);
            this.pbxLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightOff.TabIndex = 1;
            this.pbxLightOff.TabStop = false;
            this.pbxLightOff.Visible = false;
            // 
            // lblLightState
            // 
            this.lblLightState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightState.Location = new System.Drawing.Point(119, 286);
            this.lblLightState.Name = "lblLightState";
            this.lblLightState.Size = new System.Drawing.Size(105, 32);
            this.lblLightState.TabIndex = 2;
            this.lblLightState.Text = "ON";
            this.lblLightState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(84, 339);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 27);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Switch Light";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(182, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblLightState);
            this.Controls.Add(this.pbxLightOff);
            this.Controls.Add(this.pbxLightOn);
            this.Name = "Form1";
            this.Text = "Lights";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLightOn;
        private System.Windows.Forms.PictureBox pbxLightOff;
        private System.Windows.Forms.Label lblLightState;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnExit;
    }
}

