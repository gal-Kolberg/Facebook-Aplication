namespace FacebookApplicationUI
{
    partial class PictureToAsciiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureToAsciiForm));
            this.PictureToAsciiButton = new System.Windows.Forms.Button();
            this.PictureToAsciiSettingsButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.AsciiStringTextBox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PictureToAsciiButton
            // 
            this.PictureToAsciiButton.BackColor = System.Drawing.Color.LightGreen;
            this.PictureToAsciiButton.Location = new System.Drawing.Point(24, 11);
            this.PictureToAsciiButton.Name = "PictureToAsciiButton";
            this.PictureToAsciiButton.Size = new System.Drawing.Size(186, 33);
            this.PictureToAsciiButton.TabIndex = 1;
            this.PictureToAsciiButton.Text = "Make Profile Picture To Ascii";
            this.PictureToAsciiButton.UseVisualStyleBackColor = false;
            this.PictureToAsciiButton.Click += new System.EventHandler(this.PictureToAsciiButton_Click);
            // 
            // PictureToAsciiSettingsButton
            // 
            this.PictureToAsciiSettingsButton.Location = new System.Drawing.Point(242, 11);
            this.PictureToAsciiSettingsButton.Name = "PictureToAsciiSettingsButton";
            this.PictureToAsciiSettingsButton.Size = new System.Drawing.Size(184, 33);
            this.PictureToAsciiSettingsButton.TabIndex = 2;
            this.PictureToAsciiSettingsButton.Text = "&Settings";
            this.PictureToAsciiSettingsButton.UseVisualStyleBackColor = true;
            this.PictureToAsciiSettingsButton.Click += new System.EventHandler(this.PictureToAsciiSettingsButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveToFileButton.Enabled = false;
            this.SaveToFileButton.Location = new System.Drawing.Point(449, 11);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(172, 33);
            this.SaveToFileButton.TabIndex = 4;
            this.SaveToFileButton.Text = "Save To &file";
            this.SaveToFileButton.UseVisualStyleBackColor = false;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // AsciiStringTextBox
            // 
            this.AsciiStringTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsciiStringTextBox.Location = new System.Drawing.Point(8, 58);
            this.AsciiStringTextBox.Multiline = true;
            this.AsciiStringTextBox.Name = "AsciiStringTextBox";
            this.AsciiStringTextBox.ReadOnly = true;
            this.AsciiStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AsciiStringTextBox.Size = new System.Drawing.Size(711, 614);
            this.AsciiStringTextBox.TabIndex = 5;
            // 
            // DanceButton
            // 
            this.DanceButton.Location = new System.Drawing.Point(632, 21);
            this.DanceButton.Name = "DanceButton";
            this.DanceButton.Size = new System.Drawing.Size(75, 23);
            this.DanceButton.TabIndex = 58;
            this.DanceButton.Text = "Let\'s Dance";
            this.DanceButton.UseVisualStyleBackColor = true;
            this.DanceButton.Click += new System.EventHandler(this.DanceButton_Click);
            // 
            // PictureToAsciiForm
            // 
            this.AcceptButton = this.PictureToAsciiButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 676);
            this.Controls.Add(this.DanceButton);
            this.Controls.Add(this.AsciiStringTextBox);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.PictureToAsciiSettingsButton);
            this.Controls.Add(this.PictureToAsciiButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PictureToAsciiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture To Ascii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PictureToAsciiButton;
        private System.Windows.Forms.Button PictureToAsciiSettingsButton;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.TextBox AsciiStringTextBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button DanceButton;
    }
}