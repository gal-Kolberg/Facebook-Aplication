namespace FacebookApplicationUI
{
    partial class WayPointSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WayPointSelectionForm));
            this.WayPointLabel = new System.Windows.Forms.Label();
            this.WayPointsComboBox = new System.Windows.Forms.ComboBox();
            this.NextWayPointButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WayPointLabel
            // 
            this.WayPointLabel.AutoSize = true;
            this.WayPointLabel.Location = new System.Drawing.Point(159, 52);
            this.WayPointLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WayPointLabel.Name = "WayPointLabel";
            this.WayPointLabel.Size = new System.Drawing.Size(340, 32);
            this.WayPointLabel.TabIndex = 0;
            this.WayPointLabel.Text = "Pick way point number {0}";
            // 
            // WayPointsComboBox
            // 
            this.WayPointsComboBox.FormattingEnabled = true;
            this.WayPointsComboBox.Location = new System.Drawing.Point(59, 139);
            this.WayPointsComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WayPointsComboBox.Name = "WayPointsComboBox";
            this.WayPointsComboBox.Size = new System.Drawing.Size(540, 39);
            this.WayPointsComboBox.TabIndex = 1;
            this.WayPointsComboBox.SelectionChangeCommitted += new System.EventHandler(this.WayPointsComboBox_SelectionChangeCommitted);
            // 
            // NextWayPointButton
            // 
            this.NextWayPointButton.Enabled = false;
            this.NextWayPointButton.Location = new System.Drawing.Point(196, 244);
            this.NextWayPointButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NextWayPointButton.Name = "NextWayPointButton";
            this.NextWayPointButton.Size = new System.Drawing.Size(232, 79);
            this.NextWayPointButton.TabIndex = 2;
            this.NextWayPointButton.Text = "Next";
            this.NextWayPointButton.UseVisualStyleBackColor = true;
            this.NextWayPointButton.Click += new System.EventHandler(this.NextWayPointButton_Click);
            // 
            // WayPointSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 377);
            this.ControlBox = false;
            this.Controls.Add(this.NextWayPointButton);
            this.Controls.Add(this.WayPointsComboBox);
            this.Controls.Add(this.WayPointLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WayPointSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Way Point Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WayPointLabel;
        private System.Windows.Forms.ComboBox WayPointsComboBox;
        private System.Windows.Forms.Button NextWayPointButton;
    }
}