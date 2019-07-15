namespace ParentalControl
{
    partial class ParentalControl
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
            this.label_Coins = new System.Windows.Forms.Label();
            this.label_numCoins = new System.Windows.Forms.Label();
            this.timer_3_sec = new System.Windows.Forms.Timer(this.components);
            this.button_payForGames = new System.Windows.Forms.Button();
            this.timer_1_min = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_StartGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.Location = new System.Drawing.Point(226, 66);
            this.label_userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(109, 26);
            this.label_userName.TabIndex = 9;
            this.label_userName.Text = "username";
            // 
            // button_Logoff
            // 
            this.button_Logoff.Location = new System.Drawing.Point(302, 274);
            this.button_Logoff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Logoff.Name = "button_Logoff";
            this.button_Logoff.Size = new System.Drawing.Size(140, 62);
            this.button_Logoff.TabIndex = 8;
            this.button_Logoff.Text = "Log Off Now";
            this.button_Logoff.UseVisualStyleBackColor = true;
            this.button_Logoff.Click += new System.EventHandler(this.button_Logoff_Click);
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(366, 6);
            this.button_settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(76, 27);
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
            this.label_sessionTimeLeft.Location = new System.Drawing.Point(228, 127);
            this.label_sessionTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sessionTimeLeft.Name = "label_sessionTimeLeft";
            this.label_sessionTimeLeft.Size = new System.Drawing.Size(18, 20);
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
            this.label1.Location = new System.Drawing.Point(107, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(144, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time Left:";
            // 
            // label_Coins
            // 
            this.label_Coins.AutoSize = true;
            this.label_Coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Coins.Location = new System.Drawing.Point(170, 164);
            this.label_Coins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Coins.Name = "label_Coins";
            this.label_Coins.Size = new System.Drawing.Size(53, 20);
            this.label_Coins.TabIndex = 13;
            this.label_Coins.Text = "Coins:";
            // 
            // label_numCoins
            // 
            this.label_numCoins.AutoSize = true;
            this.label_numCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numCoins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_numCoins.Location = new System.Drawing.Point(228, 164);
            this.label_numCoins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numCoins.Name = "label_numCoins";
            this.label_numCoins.Size = new System.Drawing.Size(18, 20);
            this.label_numCoins.TabIndex = 12;
            this.label_numCoins.Text = "0";
            // 
            // timer_3_sec
            // 
            this.timer_3_sec.Enabled = true;
            this.timer_3_sec.Interval = 3000;
            this.timer_3_sec.Tick += new System.EventHandler(this.Timer_3_sec_Tick);
            // 
            // button_payForGames
            // 
            this.button_payForGames.BackColor = System.Drawing.Color.Maroon;
            this.button_payForGames.ForeColor = System.Drawing.Color.White;
            this.button_payForGames.Location = new System.Drawing.Point(6, 308);
            this.button_payForGames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_payForGames.Name = "button_payForGames";
            this.button_payForGames.Size = new System.Drawing.Size(140, 28);
            this.button_payForGames.TabIndex = 14;
            this.button_payForGames.Text = "Stop Games";
            this.button_payForGames.UseVisualStyleBackColor = false;
            this.button_payForGames.Click += new System.EventHandler(this.Button_payForGames_Click);
            // 
            // timer_1_min
            // 
            this.timer_1_min.Interval = 60000;
            this.timer_1_min.Tick += new System.EventHandler(this.Timer_1_min_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Konnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_StartGames
            // 
            this.button_StartGames.BackColor = System.Drawing.Color.DarkGreen;
            this.button_StartGames.ForeColor = System.Drawing.Color.White;
            this.button_StartGames.Location = new System.Drawing.Point(6, 276);
            this.button_StartGames.Margin = new System.Windows.Forms.Padding(2);
            this.button_StartGames.Name = "button_StartGames";
            this.button_StartGames.Size = new System.Drawing.Size(140, 28);
            this.button_StartGames.TabIndex = 16;
            this.button_StartGames.Text = "Start Games";
            this.button_StartGames.UseVisualStyleBackColor = false;
            this.button_StartGames.Click += new System.EventHandler(this.Button_StartGames_Click);
            // 
            // ParentalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 342);
            this.Controls.Add(this.button_StartGames);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_payForGames);
            this.Controls.Add(this.label_Coins);
            this.Controls.Add(this.label_numCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.button_Logoff);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.label_sessionTimeLeft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ParentalControl";
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
        private System.Windows.Forms.Label label_Coins;
        private System.Windows.Forms.Label label_numCoins;
        private System.Windows.Forms.Timer timer_3_sec;
        private System.Windows.Forms.Button button_payForGames;
        private System.Windows.Forms.Timer timer_1_min;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_StartGames;
    }
}

