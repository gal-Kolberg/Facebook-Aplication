namespace FacebookApplicationUI
{
    partial class PictureToAsciiSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureToAsciiSettingsForm));
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ResulotionCharsLabel = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.NumOfCharsComboBox = new System.Windows.Forms.ComboBox();
            this.BlackToWhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.WhiteToBlackRadioButton = new System.Windows.Forms.RadioButton();
            this.DefultButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(32, 67);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(243, 32);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Ascii Picture SIze:";
            // 
            // ResulotionCharsLabel
            // 
            this.ResulotionCharsLabel.AutoSize = true;
            this.ResulotionCharsLabel.Location = new System.Drawing.Point(34, 146);
            this.ResulotionCharsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ResulotionCharsLabel.Name = "ResulotionCharsLabel";
            this.ResulotionCharsLabel.Size = new System.Drawing.Size(205, 32);
            this.ResulotionCharsLabel.TabIndex = 1;
            this.ResulotionCharsLabel.Text = "Number Chars:";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(333, 60);
            this.SizeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(316, 39);
            this.SizeComboBox.TabIndex = 2;
            this.SizeComboBox.SelectionChangeCommitted += new System.EventHandler(this.SizeComboBox_SelectionChangeCommitted);
            // 
            // NumOfCharsComboBox
            // 
            this.NumOfCharsComboBox.FormattingEnabled = true;
            this.NumOfCharsComboBox.Location = new System.Drawing.Point(335, 138);
            this.NumOfCharsComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NumOfCharsComboBox.Name = "NumOfCharsComboBox";
            this.NumOfCharsComboBox.Size = new System.Drawing.Size(316, 39);
            this.NumOfCharsComboBox.TabIndex = 3;
            this.NumOfCharsComboBox.SelectionChangeCommitted += new System.EventHandler(this.NumOfCharsComboBox_SelectionChangeCommitted);
            // 
            // BlackToWhiteRadioButton
            // 
            this.BlackToWhiteRadioButton.AutoSize = true;
            this.BlackToWhiteRadioButton.Checked = true;
            this.BlackToWhiteRadioButton.Location = new System.Drawing.Point(40, 242);
            this.BlackToWhiteRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BlackToWhiteRadioButton.Name = "BlackToWhiteRadioButton";
            this.BlackToWhiteRadioButton.Size = new System.Drawing.Size(242, 36);
            this.BlackToWhiteRadioButton.TabIndex = 4;
            this.BlackToWhiteRadioButton.TabStop = true;
            this.BlackToWhiteRadioButton.Text = "Black To White";
            this.BlackToWhiteRadioButton.UseVisualStyleBackColor = true;
            this.BlackToWhiteRadioButton.Click += new System.EventHandler(this.BlackToWhiteRadioButton_Click);
            // 
            // WhiteToBlackRadioButton
            // 
            this.WhiteToBlackRadioButton.AutoSize = true;
            this.WhiteToBlackRadioButton.Location = new System.Drawing.Point(40, 328);
            this.WhiteToBlackRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WhiteToBlackRadioButton.Name = "WhiteToBlackRadioButton";
            this.WhiteToBlackRadioButton.Size = new System.Drawing.Size(242, 36);
            this.WhiteToBlackRadioButton.TabIndex = 5;
            this.WhiteToBlackRadioButton.Text = "White To Black";
            this.WhiteToBlackRadioButton.UseVisualStyleBackColor = true;
            this.WhiteToBlackRadioButton.Click += new System.EventHandler(this.WhiteToBlackRadioButton_Click);
            // 
            // DefultButton
            // 
            this.DefultButton.Location = new System.Drawing.Point(355, 242);
            this.DefultButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DefultButton.Name = "DefultButton";
            this.DefultButton.Size = new System.Drawing.Size(277, 55);
            this.DefultButton.TabIndex = 6;
            this.DefultButton.Text = "&Defult Settings";
            this.DefultButton.UseVisualStyleBackColor = true;
            this.DefultButton.Click += new System.EventHandler(this.DefultButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(355, 328);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(277, 55);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PictureToAsciiSettings
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 419);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DefultButton);
            this.Controls.Add(this.WhiteToBlackRadioButton);
            this.Controls.Add(this.BlackToWhiteRadioButton);
            this.Controls.Add(this.NumOfCharsComboBox);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.ResulotionCharsLabel);
            this.Controls.Add(this.SizeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PictureToAsciiSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PictureToAsciiSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureToAsciiSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ResulotionCharsLabel;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox NumOfCharsComboBox;
        private System.Windows.Forms.RadioButton BlackToWhiteRadioButton;
        private System.Windows.Forms.RadioButton WhiteToBlackRadioButton;
        private System.Windows.Forms.Button DefultButton;
        private System.Windows.Forms.Button SaveButton;
    }
}