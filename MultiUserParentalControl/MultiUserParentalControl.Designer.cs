﻿namespace MultiUserParentalControl
{
    partial class MultiUserParentalControl
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
            this.components = new System.ComponentModel.Container();
            this.label_userName = new System.Windows.Forms.Label();
            this.button_Logoff = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.label_sessionTimeLeft = new System.Windows.Forms.Label();
            this.timer_1_sec = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.Location = new System.Drawing.Point(453, 126);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(214, 51);
            this.label_userName.TabIndex = 9;
            this.label_userName.Text = "username";
            // 
            // button_Logoff
            // 
            this.button_Logoff.Location = new System.Drawing.Point(603, 527);
            this.button_Logoff.Name = "button_Logoff";
            this.button_Logoff.Size = new System.Drawing.Size(281, 119);
            this.button_Logoff.TabIndex = 8;
            this.button_Logoff.Text = "Log Off Now";
            this.button_Logoff.UseVisualStyleBackColor = true;
            this.button_Logoff.Click += new System.EventHandler(this.button_Logoff_Click);
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(731, 12);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(153, 51);
            this.button_settings.TabIndex = 7;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // label_sessionTimeLeft
            // 
            this.label_sessionTimeLeft.AutoSize = true;
            this.label_sessionTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sessionTimeLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_sessionTimeLeft.Location = new System.Drawing.Point(455, 244);
            this.label_sessionTimeLeft.Name = "label_sessionTimeLeft";
            this.label_sessionTimeLeft.Size = new System.Drawing.Size(35, 37);
            this.label_sessionTimeLeft.TabIndex = 6;
            this.label_sessionTimeLeft.Text = "0";
            // 
            // timer_1_sec
            // 
            this.timer_1_sec.Enabled = true;
            this.timer_1_sec.Interval = 1000;
            this.timer_1_sec.Tick += new System.EventHandler(this.timer_1_sec_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(288, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time Left:";
            // 
            // MultiUserParentalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.button_Logoff);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.label_sessionTimeLeft);
            this.Name = "MultiUserParentalControl";
            this.Text = "MultiUserParentalControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Button button_Logoff;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Label label_sessionTimeLeft;
        private System.Windows.Forms.Timer timer_1_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

