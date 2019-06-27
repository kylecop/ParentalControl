namespace ParentalControl.Forms
{
    partial class Settings
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
            this.maskedTextBox_newPIN = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_newPIN_Confirmation = new System.Windows.Forms.MaskedTextBox();
            this.button_newPIN_Save = new System.Windows.Forms.Button();
            this.label_newPIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SessionLimit_Decrease = new System.Windows.Forms.Button();
            this.textBox_SessionLimit = new System.Windows.Forms.TextBox();
            this.button_SessionLimit_Increase = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_increaseCoins = new System.Windows.Forms.Button();
            this.label_Coins = new System.Windows.Forms.Label();
            this.button_decreaseCoins = new System.Windows.Forms.Button();
            this.textBox_numCoins = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_findExecutable = new System.Windows.Forms.Button();
            this.button_checkedListBox1Delete = new System.Windows.Forms.Button();
            this.button_increaseRequiredCoins = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_decreaseRequiredCoins = new System.Windows.Forms.Button();
            this.textBox_requiredCoins = new System.Windows.Forms.TextBox();
            this.button_newCheckedListBox1Item = new System.Windows.Forms.Button();
            this.textBox_checkedListBoxItemText = new System.Windows.Forms.TextBox();
            this.button_addNewExe = new System.Windows.Forms.Button();
            this.button_tempSessionLimitIncrease = new System.Windows.Forms.Button();
            this.label_tempSessionLimit = new System.Windows.Forms.Label();
            this.button_tempSessionLimitDecrease = new System.Windows.Forms.Button();
            this.textBox_tempSessionLimit = new System.Windows.Forms.TextBox();
            this.button_countdownReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_newPIN
            // 
            this.maskedTextBox_newPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_newPIN.Location = new System.Drawing.Point(731, 82);
            this.maskedTextBox_newPIN.Name = "maskedTextBox_newPIN";
            this.maskedTextBox_newPIN.PasswordChar = '*';
            this.maskedTextBox_newPIN.Size = new System.Drawing.Size(100, 44);
            this.maskedTextBox_newPIN.TabIndex = 0;
            // 
            // maskedTextBox_newPIN_Confirmation
            // 
            this.maskedTextBox_newPIN_Confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_newPIN_Confirmation.Location = new System.Drawing.Point(731, 132);
            this.maskedTextBox_newPIN_Confirmation.Name = "maskedTextBox_newPIN_Confirmation";
            this.maskedTextBox_newPIN_Confirmation.PasswordChar = '*';
            this.maskedTextBox_newPIN_Confirmation.Size = new System.Drawing.Size(100, 44);
            this.maskedTextBox_newPIN_Confirmation.TabIndex = 1;
            // 
            // button_newPIN_Save
            // 
            this.button_newPIN_Save.Location = new System.Drawing.Point(837, 132);
            this.button_newPIN_Save.Name = "button_newPIN_Save";
            this.button_newPIN_Save.Size = new System.Drawing.Size(121, 44);
            this.button_newPIN_Save.TabIndex = 2;
            this.button_newPIN_Save.Text = "Save";
            this.button_newPIN_Save.UseVisualStyleBackColor = true;
            this.button_newPIN_Save.Click += new System.EventHandler(this.button_newPIN_Save_Click);
            // 
            // label_newPIN
            // 
            this.label_newPIN.AutoSize = true;
            this.label_newPIN.Location = new System.Drawing.Point(613, 94);
            this.label_newPIN.Name = "label_newPIN";
            this.label_newPIN.Size = new System.Drawing.Size(100, 25);
            this.label_newPIN.TabIndex = 3;
            this.label_newPIN.Text = "New PIN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(576, 569);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(382, 81);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(12, 569);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(382, 81);
            this.button_Apply.TabIndex = 7;
            this.button_Apply.Text = "Apply and Close";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Session Limit: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SessionLimit_Decrease
            // 
            this.button_SessionLimit_Decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SessionLimit_Decrease.Location = new System.Drawing.Point(222, 12);
            this.button_SessionLimit_Decrease.Name = "button_SessionLimit_Decrease";
            this.button_SessionLimit_Decrease.Size = new System.Drawing.Size(61, 55);
            this.button_SessionLimit_Decrease.TabIndex = 1;
            this.button_SessionLimit_Decrease.Text = "-";
            this.button_SessionLimit_Decrease.UseVisualStyleBackColor = true;
            this.button_SessionLimit_Decrease.Click += new System.EventHandler(this.button_SessionLimit_Decrease_Click);
            // 
            // textBox_SessionLimit
            // 
            this.textBox_SessionLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SessionLimit.Location = new System.Drawing.Point(289, 15);
            this.textBox_SessionLimit.Name = "textBox_SessionLimit";
            this.textBox_SessionLimit.Size = new System.Drawing.Size(68, 50);
            this.textBox_SessionLimit.TabIndex = 2;
            this.textBox_SessionLimit.TextChanged += new System.EventHandler(this.textBox_SessionLimit_TextChanged);
            // 
            // button_SessionLimit_Increase
            // 
            this.button_SessionLimit_Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SessionLimit_Increase.Location = new System.Drawing.Point(363, 12);
            this.button_SessionLimit_Increase.Name = "button_SessionLimit_Increase";
            this.button_SessionLimit_Increase.Size = new System.Drawing.Size(61, 55);
            this.button_SessionLimit_Increase.TabIndex = 8;
            this.button_SessionLimit_Increase.Text = "+";
            this.button_SessionLimit_Increase.UseVisualStyleBackColor = true;
            this.button_SessionLimit_Increase.Click += new System.EventHandler(this.button_SessionLimit_Increase_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(764, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(194, 50);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "Close and Exit";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_increaseCoins
            // 
            this.button_increaseCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_increaseCoins.Location = new System.Drawing.Point(868, 248);
            this.button_increaseCoins.Name = "button_increaseCoins";
            this.button_increaseCoins.Size = new System.Drawing.Size(90, 90);
            this.button_increaseCoins.TabIndex = 13;
            this.button_increaseCoins.Text = "+20";
            this.button_increaseCoins.UseVisualStyleBackColor = true;
            this.button_increaseCoins.Click += new System.EventHandler(this.Button_increaseCoins_Click);
            // 
            // label_Coins
            // 
            this.label_Coins.AutoSize = true;
            this.label_Coins.Location = new System.Drawing.Point(565, 280);
            this.label_Coins.Name = "label_Coins";
            this.label_Coins.Size = new System.Drawing.Size(79, 25);
            this.label_Coins.TabIndex = 10;
            this.label_Coins.Text = "Coins: ";
            this.label_Coins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_decreaseCoins
            // 
            this.button_decreaseCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decreaseCoins.Location = new System.Drawing.Point(650, 248);
            this.button_decreaseCoins.Name = "button_decreaseCoins";
            this.button_decreaseCoins.Size = new System.Drawing.Size(90, 90);
            this.button_decreaseCoins.TabIndex = 11;
            this.button_decreaseCoins.Text = "-20";
            this.button_decreaseCoins.UseVisualStyleBackColor = true;
            this.button_decreaseCoins.Click += new System.EventHandler(this.Button_decreaseCoins_Click);
            // 
            // textBox_numCoins
            // 
            this.textBox_numCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numCoins.Location = new System.Drawing.Point(746, 248);
            this.textBox_numCoins.Name = "textBox_numCoins";
            this.textBox_numCoins.Size = new System.Drawing.Size(116, 86);
            this.textBox_numCoins.TabIndex = 12;
            this.textBox_numCoins.TextChanged += new System.EventHandler(this.TextBox_numCoins_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 206);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(468, 228);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 14;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Executable files (*.exe)|*.exe\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // button_findExecutable
            // 
            this.button_findExecutable.Location = new System.Drawing.Point(250, 440);
            this.button_findExecutable.Name = "button_findExecutable";
            this.button_findExecutable.Size = new System.Drawing.Size(230, 51);
            this.button_findExecutable.TabIndex = 15;
            this.button_findExecutable.Text = "Find Executable";
            this.button_findExecutable.UseVisualStyleBackColor = true;
            this.button_findExecutable.Click += new System.EventHandler(this.Button_findExecutable_Click);
            // 
            // button_checkedListBox1Delete
            // 
            this.button_checkedListBox1Delete.Location = new System.Drawing.Point(149, 440);
            this.button_checkedListBox1Delete.Name = "button_checkedListBox1Delete";
            this.button_checkedListBox1Delete.Size = new System.Drawing.Size(95, 51);
            this.button_checkedListBox1Delete.TabIndex = 16;
            this.button_checkedListBox1Delete.Text = "Delete";
            this.button_checkedListBox1Delete.UseVisualStyleBackColor = true;
            this.button_checkedListBox1Delete.Click += new System.EventHandler(this.Button_checkedListBox1Delete_Click);
            // 
            // button_increaseRequiredCoins
            // 
            this.button_increaseRequiredCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_increaseRequiredCoins.Location = new System.Drawing.Point(363, 134);
            this.button_increaseRequiredCoins.Name = "button_increaseRequiredCoins";
            this.button_increaseRequiredCoins.Size = new System.Drawing.Size(61, 55);
            this.button_increaseRequiredCoins.TabIndex = 20;
            this.button_increaseRequiredCoins.Text = "+";
            this.button_increaseRequiredCoins.UseVisualStyleBackColor = true;
            this.button_increaseRequiredCoins.Click += new System.EventHandler(this.Button_increaseRequiredCoins_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Required to Play: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_decreaseRequiredCoins
            // 
            this.button_decreaseRequiredCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decreaseRequiredCoins.Location = new System.Drawing.Point(222, 134);
            this.button_decreaseRequiredCoins.Name = "button_decreaseRequiredCoins";
            this.button_decreaseRequiredCoins.Size = new System.Drawing.Size(61, 55);
            this.button_decreaseRequiredCoins.TabIndex = 18;
            this.button_decreaseRequiredCoins.Text = "-";
            this.button_decreaseRequiredCoins.UseVisualStyleBackColor = true;
            this.button_decreaseRequiredCoins.Click += new System.EventHandler(this.Button_decreaseRequiredCoins_Click);
            // 
            // textBox_requiredCoins
            // 
            this.textBox_requiredCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_requiredCoins.Location = new System.Drawing.Point(289, 137);
            this.textBox_requiredCoins.Name = "textBox_requiredCoins";
            this.textBox_requiredCoins.Size = new System.Drawing.Size(68, 50);
            this.textBox_requiredCoins.TabIndex = 19;
            this.textBox_requiredCoins.TextChanged += new System.EventHandler(this.TextBox_requiredCoins_TextChanged);
            // 
            // button_newCheckedListBox1Item
            // 
            this.button_newCheckedListBox1Item.Location = new System.Drawing.Point(12, 440);
            this.button_newCheckedListBox1Item.Name = "button_newCheckedListBox1Item";
            this.button_newCheckedListBox1Item.Size = new System.Drawing.Size(131, 51);
            this.button_newCheckedListBox1Item.TabIndex = 21;
            this.button_newCheckedListBox1Item.Text = "New";
            this.button_newCheckedListBox1Item.UseVisualStyleBackColor = true;
            // 
            // textBox_checkedListBoxItemText
            // 
            this.textBox_checkedListBoxItemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_checkedListBoxItemText.Location = new System.Drawing.Point(12, 497);
            this.textBox_checkedListBoxItemText.Name = "textBox_checkedListBoxItemText";
            this.textBox_checkedListBoxItemText.Size = new System.Drawing.Size(368, 50);
            this.textBox_checkedListBoxItemText.TabIndex = 22;
            this.textBox_checkedListBoxItemText.TextChanged += new System.EventHandler(this.TextBox_checkedListBoxItemText_TextChanged);
            // 
            // button_addNewExe
            // 
            this.button_addNewExe.Location = new System.Drawing.Point(385, 496);
            this.button_addNewExe.Name = "button_addNewExe";
            this.button_addNewExe.Size = new System.Drawing.Size(95, 51);
            this.button_addNewExe.TabIndex = 23;
            this.button_addNewExe.Text = "Add";
            this.button_addNewExe.UseVisualStyleBackColor = true;
            this.button_addNewExe.Click += new System.EventHandler(this.Button_addNewExe_Click);
            // 
            // button_tempSessionLimitIncrease
            // 
            this.button_tempSessionLimitIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempSessionLimitIncrease.Location = new System.Drawing.Point(363, 73);
            this.button_tempSessionLimitIncrease.Name = "button_tempSessionLimitIncrease";
            this.button_tempSessionLimitIncrease.Size = new System.Drawing.Size(61, 55);
            this.button_tempSessionLimitIncrease.TabIndex = 27;
            this.button_tempSessionLimitIncrease.Text = "+";
            this.button_tempSessionLimitIncrease.UseVisualStyleBackColor = true;
            this.button_tempSessionLimitIncrease.Click += new System.EventHandler(this.Button_tempSessionLimitIncrease_Click);
            // 
            // label_tempSessionLimit
            // 
            this.label_tempSessionLimit.AutoSize = true;
            this.label_tempSessionLimit.Location = new System.Drawing.Point(4, 94);
            this.label_tempSessionLimit.Name = "label_tempSessionLimit";
            this.label_tempSessionLimit.Size = new System.Drawing.Size(212, 25);
            this.label_tempSessionLimit.TabIndex = 24;
            this.label_tempSessionLimit.Text = "Temp Session Limit: ";
            this.label_tempSessionLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_tempSessionLimitDecrease
            // 
            this.button_tempSessionLimitDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempSessionLimitDecrease.Location = new System.Drawing.Point(222, 73);
            this.button_tempSessionLimitDecrease.Name = "button_tempSessionLimitDecrease";
            this.button_tempSessionLimitDecrease.Size = new System.Drawing.Size(61, 55);
            this.button_tempSessionLimitDecrease.TabIndex = 25;
            this.button_tempSessionLimitDecrease.Text = "-";
            this.button_tempSessionLimitDecrease.UseVisualStyleBackColor = true;
            this.button_tempSessionLimitDecrease.Click += new System.EventHandler(this.Button_tempSessionLimitDecrease_Click);
            // 
            // textBox_tempSessionLimit
            // 
            this.textBox_tempSessionLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tempSessionLimit.Location = new System.Drawing.Point(289, 76);
            this.textBox_tempSessionLimit.Name = "textBox_tempSessionLimit";
            this.textBox_tempSessionLimit.Size = new System.Drawing.Size(68, 50);
            this.textBox_tempSessionLimit.TabIndex = 26;
            this.textBox_tempSessionLimit.TextChanged += new System.EventHandler(this.TextBox_tempSessionLimit_TextChanged);
            // 
            // button_countdownReset
            // 
            this.button_countdownReset.Location = new System.Drawing.Point(448, 12);
            this.button_countdownReset.Name = "button_countdownReset";
            this.button_countdownReset.Size = new System.Drawing.Size(230, 50);
            this.button_countdownReset.TabIndex = 28;
            this.button_countdownReset.Text = "Reset Countdown";
            this.button_countdownReset.UseVisualStyleBackColor = true;
            this.button_countdownReset.Click += new System.EventHandler(this.Button_countdownReset_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 662);
            this.Controls.Add(this.button_countdownReset);
            this.Controls.Add(this.button_tempSessionLimitIncrease);
            this.Controls.Add(this.label_tempSessionLimit);
            this.Controls.Add(this.button_tempSessionLimitDecrease);
            this.Controls.Add(this.textBox_tempSessionLimit);
            this.Controls.Add(this.button_addNewExe);
            this.Controls.Add(this.textBox_checkedListBoxItemText);
            this.Controls.Add(this.button_newCheckedListBox1Item);
            this.Controls.Add(this.button_increaseRequiredCoins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_decreaseRequiredCoins);
            this.Controls.Add(this.textBox_requiredCoins);
            this.Controls.Add(this.button_checkedListBox1Delete);
            this.Controls.Add(this.button_findExecutable);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button_increaseCoins);
            this.Controls.Add(this.label_Coins);
            this.Controls.Add(this.button_decreaseCoins);
            this.Controls.Add(this.textBox_numCoins);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_SessionLimit_Increase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SessionLimit_Decrease);
            this.Controls.Add(this.textBox_SessionLimit);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_newPIN);
            this.Controls.Add(this.button_newPIN_Save);
            this.Controls.Add(this.maskedTextBox_newPIN_Confirmation);
            this.Controls.Add(this.maskedTextBox_newPIN);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_newPIN;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_newPIN_Confirmation;
        private System.Windows.Forms.Button button_newPIN_Save;
        private System.Windows.Forms.Label label_newPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SessionLimit_Decrease;
        private System.Windows.Forms.TextBox textBox_SessionLimit;
        private System.Windows.Forms.Button button_SessionLimit_Increase;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_increaseCoins;
        private System.Windows.Forms.Label label_Coins;
        private System.Windows.Forms.Button button_decreaseCoins;
        private System.Windows.Forms.TextBox textBox_numCoins;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_findExecutable;
        private System.Windows.Forms.Button button_checkedListBox1Delete;
        private System.Windows.Forms.Button button_increaseRequiredCoins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_decreaseRequiredCoins;
        private System.Windows.Forms.TextBox textBox_requiredCoins;
        private System.Windows.Forms.Button button_newCheckedListBox1Item;
        private System.Windows.Forms.TextBox textBox_checkedListBoxItemText;
        private System.Windows.Forms.Button button_addNewExe;
        private System.Windows.Forms.Button button_tempSessionLimitIncrease;
        private System.Windows.Forms.Label label_tempSessionLimit;
        private System.Windows.Forms.Button button_tempSessionLimitDecrease;
        private System.Windows.Forms.TextBox textBox_tempSessionLimit;
        private System.Windows.Forms.Button button_countdownReset;
    }
}