/*
    qanazgoa's AdHocLauncher Version 1
    Copyright (C) 2015  qanazoga
*/
namespace AdHocLaunch
{
    partial class AdHocGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdHocGui));
            this.labelSsid = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxSsid = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelStatusStatic = new System.Windows.Forms.Label();
            this.labelStatusActive = new System.Windows.Forms.Label();
            this.labelInfoSpaces = new System.Windows.Forms.Label();
            this.labelInfoLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSsid
            // 
            this.labelSsid.AutoSize = true;
            this.labelSsid.Location = new System.Drawing.Point(12, 9);
            this.labelSsid.Name = "labelSsid";
            this.labelSsid.Size = new System.Drawing.Size(32, 13);
            this.labelSsid.TabIndex = 0;
            this.labelSsid.Text = "SSID";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(201, 51);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 1;
            this.buttonStartStop.Text = "START";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // textBoxSsid
            // 
            this.textBoxSsid.Location = new System.Drawing.Point(15, 25);
            this.textBoxSsid.Name = "textBoxSsid";
            this.textBoxSsid.Size = new System.Drawing.Size(127, 20);
            this.textBoxSsid.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(145, 9);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.Location = new System.Drawing.Point(148, 25);
            this.textBoxPassword.MaxLength = 64;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(127, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelStatusStatic
            // 
            this.labelStatusStatic.AutoSize = true;
            this.labelStatusStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusStatic.Location = new System.Drawing.Point(12, 56);
            this.labelStatusStatic.Name = "labelStatusStatic";
            this.labelStatusStatic.Size = new System.Drawing.Size(127, 13);
            this.labelStatusStatic.TabIndex = 5;
            this.labelStatusStatic.Text = "NETWORK STATUS:";
            // 
            // labelStatusActive
            // 
            this.labelStatusActive.AutoSize = true;
            this.labelStatusActive.ForeColor = System.Drawing.Color.Red;
            this.labelStatusActive.Location = new System.Drawing.Point(145, 56);
            this.labelStatusActive.Name = "labelStatusActive";
            this.labelStatusActive.Size = new System.Drawing.Size(21, 13);
            this.labelStatusActive.TabIndex = 6;
            this.labelStatusActive.Text = "Off";
            // 
            // labelInfoSpaces
            // 
            this.labelInfoSpaces.AutoSize = true;
            this.labelInfoSpaces.Location = new System.Drawing.Point(4, 77);
            this.labelInfoSpaces.Name = "labelInfoSpaces";
            this.labelInfoSpaces.Size = new System.Drawing.Size(272, 13);
            this.labelInfoSpaces.TabIndex = 7;
            this.labelInfoSpaces.Text = "SSID and Password may not contain spaces or symbols.\r\n";
            // 
            // labelInfoLength
            // 
            this.labelInfoLength.AutoSize = true;
            this.labelInfoLength.Location = new System.Drawing.Point(4, 89);
            this.labelInfoLength.Name = "labelInfoLength";
            this.labelInfoLength.Size = new System.Drawing.Size(170, 13);
            this.labelInfoLength.TabIndex = 8;
            this.labelInfoLength.Text = "Password must be 8-64 characters";
            this.labelInfoLength.Click += new System.EventHandler(this.labelInfoLength_Click);
            // 
            // AdHocGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 111);
            this.ControlBox = false;
            this.Controls.Add(this.labelInfoLength);
            this.Controls.Add(this.labelInfoSpaces);
            this.Controls.Add(this.labelStatusActive);
            this.Controls.Add(this.labelStatusStatic);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxSsid);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelSsid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdHocGui";
            this.Text = "Leafy\'s AdHoc Controller 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSsid;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxSsid;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelStatusStatic;
        private System.Windows.Forms.Label labelStatusActive;
        private System.Windows.Forms.Label labelInfoSpaces;
        private System.Windows.Forms.Label labelInfoLength;
    }
}

