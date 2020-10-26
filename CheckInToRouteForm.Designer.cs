using FacebookWrapper.ObjectModel;
using FacebookApplicationLogic;

namespace FacebookApplicationUI
{
    partial class CheckInToRouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInToRouteForm));
            this.StopsLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.NumberOfStopsComboBox = new System.Windows.Forms.ComboBox();
            this.DestinationComboBox = new System.Windows.Forms.ComboBox();
            this.OriginComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckInRouteInfoLabel = new System.Windows.Forms.Label();
            this.CheckInToRouteButton = new System.Windows.Forms.Button();
            this.SelectWayPointButton = new System.Windows.Forms.Button();
            this.DanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StopsLabel
            // 
            this.StopsLabel.AutoSize = true;
            this.StopsLabel.Location = new System.Drawing.Point(8, 195);
            this.StopsLabel.Name = "StopsLabel";
            this.StopsLabel.Size = new System.Drawing.Size(130, 13);
            this.StopsLabel.TabIndex = 14;
            this.StopsLabel.Text = "Choose Number Of Stops:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(8, 126);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(102, 13);
            this.DestinationLabel.TabIndex = 13;
            this.DestinationLabel.Text = "Choose Destination:";
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(8, 67);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(76, 13);
            this.OriginLabel.TabIndex = 12;
            this.OriginLabel.Text = "Choose Origin:";
            // 
            // NumberOfStopsComboBox
            // 
            this.NumberOfStopsComboBox.FormattingEnabled = true;
            this.NumberOfStopsComboBox.Location = new System.Drawing.Point(11, 224);
            this.NumberOfStopsComboBox.Name = "NumberOfStopsComboBox";
            this.NumberOfStopsComboBox.Size = new System.Drawing.Size(322, 21);
            this.NumberOfStopsComboBox.TabIndex = 11;
            // 
            // DestinationComboBox
            // 
            this.DestinationComboBox.FormattingEnabled = true;
            this.DestinationComboBox.Location = new System.Drawing.Point(11, 157);
            this.DestinationComboBox.Name = "DestinationComboBox";
            this.DestinationComboBox.Size = new System.Drawing.Size(322, 21);
            this.DestinationComboBox.TabIndex = 10;
            // 
            // OriginComboBox
            // 
            this.OriginComboBox.FormattingEnabled = true;
            this.OriginComboBox.Location = new System.Drawing.Point(11, 93);
            this.OriginComboBox.Name = "OriginComboBox";
            this.OriginComboBox.Size = new System.Drawing.Size(322, 21);
            this.OriginComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "This feature creates a path in google maps with all your checkin, \r\nplease select" +
    " where you want to start the path and where to finish it.\r\nYou can choose up to " +
    "9 stops along the way.\r\n";
            // 
            // CheckInRouteInfoLabel
            // 
            this.CheckInRouteInfoLabel.AutoSize = true;
            this.CheckInRouteInfoLabel.Location = new System.Drawing.Point(9, 255);
            this.CheckInRouteInfoLabel.Name = "CheckInRouteInfoLabel";
            this.CheckInRouteInfoLabel.Size = new System.Drawing.Size(154, 26);
            this.CheckInRouteInfoLabel.TabIndex = 16;
            this.CheckInRouteInfoLabel.Text = "Please check the places \r\nthat you want to see a route of:";
            // 
            // CheckInToRouteButton
            // 
            this.CheckInToRouteButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckInToRouteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckInToRouteButton.BackgroundImage")));
            this.CheckInToRouteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInToRouteButton.Location = new System.Drawing.Point(177, 314);
            this.CheckInToRouteButton.Name = "CheckInToRouteButton";
            this.CheckInToRouteButton.Size = new System.Drawing.Size(153, 48);
            this.CheckInToRouteButton.TabIndex = 18;
            this.CheckInToRouteButton.Text = "Get Route from Checkings";
            this.CheckInToRouteButton.UseVisualStyleBackColor = false;
            this.CheckInToRouteButton.Click += new System.EventHandler(this.CheckInToRouteButton_Click);
            // 
            // SelectWayPointButton
            // 
            this.SelectWayPointButton.BackColor = System.Drawing.Color.Violet;
            this.SelectWayPointButton.Location = new System.Drawing.Point(177, 258);
            this.SelectWayPointButton.Name = "SelectWayPointButton";
            this.SelectWayPointButton.Size = new System.Drawing.Size(153, 24);
            this.SelectWayPointButton.TabIndex = 19;
            this.SelectWayPointButton.Text = "Select Way Points";
            this.SelectWayPointButton.UseVisualStyleBackColor = false;
            this.SelectWayPointButton.Click += new System.EventHandler(this.SelectWayPointButton_Click);
            // 
            // DanceButton
            // 
            this.DanceButton.Location = new System.Drawing.Point(12, 373);
            this.DanceButton.Name = "DanceButton";
            this.DanceButton.Size = new System.Drawing.Size(75, 23);
            this.DanceButton.TabIndex = 59;
            this.DanceButton.Text = "Let\'s Dance";
            this.DanceButton.UseVisualStyleBackColor = true;
            this.DanceButton.Click += new System.EventHandler(this.DanceButton_Click);
            // 
            // CheckInToRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 408);
            this.Controls.Add(this.DanceButton);
            this.Controls.Add(this.SelectWayPointButton);
            this.Controls.Add(this.CheckInToRouteButton);
            this.Controls.Add(this.CheckInRouteInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopsLabel);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.OriginLabel);
            this.Controls.Add(this.NumberOfStopsComboBox);
            this.Controls.Add(this.DestinationComboBox);
            this.Controls.Add(this.OriginComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInToRouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In To Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StopsLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.ComboBox NumberOfStopsComboBox;
        private System.Windows.Forms.ComboBox DestinationComboBox;
        private System.Windows.Forms.ComboBox OriginComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CheckInRouteInfoLabel;
        private System.Windows.Forms.Button CheckInToRouteButton;
        private System.Windows.Forms.Button SelectWayPointButton;
        private System.Windows.Forms.Button DanceButton;
    }
}