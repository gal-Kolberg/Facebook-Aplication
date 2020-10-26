namespace FacebookApplicationUI
{
    partial class PackageForm
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
            this.FreePackageButton = new System.Windows.Forms.Button();
            this.PremiumUserButton = new System.Windows.Forms.Button();
            this.BusinessUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FreePackageButton
            // 
            this.FreePackageButton.Location = new System.Drawing.Point(21, 34);
            this.FreePackageButton.Name = "FreePackageButton";
            this.FreePackageButton.Size = new System.Drawing.Size(100, 34);
            this.FreePackageButton.TabIndex = 0;
            this.FreePackageButton.Text = "Free User";
            this.FreePackageButton.UseVisualStyleBackColor = true;
            this.FreePackageButton.Click += new System.EventHandler(this.FreePackageButton_Click);
            // 
            // PremiumUserButton
            // 
            this.PremiumUserButton.BackColor = System.Drawing.Color.Gold;
            this.PremiumUserButton.Location = new System.Drawing.Point(21, 192);
            this.PremiumUserButton.Name = "PremiumUserButton";
            this.PremiumUserButton.Size = new System.Drawing.Size(100, 34);
            this.PremiumUserButton.TabIndex = 1;
            this.PremiumUserButton.Text = "Premium User";
            this.PremiumUserButton.UseVisualStyleBackColor = false;
            this.PremiumUserButton.Click += new System.EventHandler(this.PremiumUserButton_Click);
            // 
            // BusinessUserButton
            // 
            this.BusinessUserButton.BackColor = System.Drawing.Color.Peru;
            this.BusinessUserButton.Location = new System.Drawing.Point(21, 108);
            this.BusinessUserButton.Name = "BusinessUserButton";
            this.BusinessUserButton.Size = new System.Drawing.Size(100, 34);
            this.BusinessUserButton.TabIndex = 2;
            this.BusinessUserButton.Text = "Business User";
            this.BusinessUserButton.UseVisualStyleBackColor = false;
            this.BusinessUserButton.Click += new System.EventHandler(this.BusinessUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Give some of the bonus features";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Full experience of the \r\nD&&G facebook app";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Give the minimum of the \r\nD&&G facebook app";
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 266);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BusinessUserButton);
            this.Controls.Add(this.PremiumUserButton);
            this.Controls.Add(this.FreePackageButton);
            this.Name = "PackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PackageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FreePackageButton;
        private System.Windows.Forms.Button PremiumUserButton;
        private System.Windows.Forms.Button BusinessUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}