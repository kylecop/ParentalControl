namespace MultiUserParentalControl.Forms
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
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Session Limit: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SessionLimit_Decrease
            // 
            this.button_SessionLimit_Decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SessionLimit_Decrease.Location = new System.Drawing.Point(168, 19);
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
            this.textBox_SessionLimit.Location = new System.Drawing.Point(235, 22);
            this.textBox_SessionLimit.Name = "textBox_SessionLimit";
            this.textBox_SessionLimit.Size = new System.Drawing.Size(68, 50);
            this.textBox_SessionLimit.TabIndex = 2;
            this.textBox_SessionLimit.TextChanged += new System.EventHandler(this.textBox_SessionLimit_TextChanged);
            // 
            // button_SessionLimit_Increase
            // 
            this.button_SessionLimit_Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SessionLimit_Increase.Location = new System.Drawing.Point(309, 19);
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 662);
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
    }
}