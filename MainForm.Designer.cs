namespace FacebookApplicationUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CheckInToRouteButton = new System.Windows.Forms.Button();
            this.PictureToAsciiButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EventsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.LastPostLabel = new System.Windows.Forms.Label();
            this.LastPostTextBox = new System.Windows.Forms.TextBox();
            this.GroupsLinkLable = new System.Windows.Forms.LinkLabel();
            this.CoverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.LikedPages = new System.Windows.Forms.LinkLabel();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.FecthFriendsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FriendsTextBox = new System.Windows.Forms.TextBox();
            this.LikedPagesTextBox = new System.Windows.Forms.TextBox();
            this.FetchCoverPhotoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GroupsTextBox = new System.Windows.Forms.TextBox();
            this.PackageSelectButton = new System.Windows.Forms.Button();
            this.DanceButton = new System.Windows.Forms.Button();
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortFriednsByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckInToRouteButton
            // 
            this.CheckInToRouteButton.BackColor = System.Drawing.Color.LightGray;
            this.CheckInToRouteButton.Enabled = false;
            this.CheckInToRouteButton.Location = new System.Drawing.Point(278, 110);
            this.CheckInToRouteButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckInToRouteButton.Name = "CheckInToRouteButton";
            this.CheckInToRouteButton.Size = new System.Drawing.Size(152, 30);
            this.CheckInToRouteButton.TabIndex = 55;
            this.CheckInToRouteButton.Text = "CheckIn To Route";
            this.CheckInToRouteButton.UseVisualStyleBackColor = false;
            this.CheckInToRouteButton.Click += new System.EventHandler(this.CheckInToRouteButton_Click);
            // 
            // PictureToAsciiButton
            // 
            this.PictureToAsciiButton.BackColor = System.Drawing.Color.LightGray;
            this.PictureToAsciiButton.Enabled = false;
            this.PictureToAsciiButton.Location = new System.Drawing.Point(278, 66);
            this.PictureToAsciiButton.Margin = new System.Windows.Forms.Padding(2);
            this.PictureToAsciiButton.Name = "PictureToAsciiButton";
            this.PictureToAsciiButton.Size = new System.Drawing.Size(152, 30);
            this.PictureToAsciiButton.TabIndex = 54;
            this.PictureToAsciiButton.Text = "Profile To Ascii";
            this.PictureToAsciiButton.UseVisualStyleBackColor = false;
            this.PictureToAsciiButton.Click += new System.EventHandler(this.PictureToAsciiButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.RosyBrown;
            this.LogoutButton.Enabled = false;
            this.LogoutButton.Location = new System.Drawing.Point(166, 20);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 39);
            this.LogoutButton.TabIndex = 53;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click_1);
            // 
            // EventsLinkLabel
            // 
            this.EventsLinkLabel.AutoSize = true;
            this.EventsLinkLabel.Enabled = false;
            this.EventsLinkLabel.Location = new System.Drawing.Point(519, 432);
            this.EventsLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventsLinkLabel.Name = "EventsLinkLabel";
            this.EventsLinkLabel.Size = new System.Drawing.Size(90, 17);
            this.EventsLinkLabel.TabIndex = 52;
            this.EventsLinkLabel.TabStop = true;
            this.EventsLinkLabel.Text = "Fetch Events";
            this.EventsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EventsLinkLabel_LinkClicked_1);
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(516, 466);
            this.EventTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EventTextBox.Multiline = true;
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.ReadOnly = true;
            this.EventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EventTextBox.Size = new System.Drawing.Size(214, 186);
            this.EventTextBox.TabIndex = 51;
            // 
            // LastPostLabel
            // 
            this.LastPostLabel.AutoSize = true;
            this.LastPostLabel.Location = new System.Drawing.Point(276, 432);
            this.LastPostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastPostLabel.Name = "LastPostLabel";
            this.LastPostLabel.Size = new System.Drawing.Size(147, 17);
            this.LastPostLabel.TabIndex = 48;
            this.LastPostLabel.Text = "Last Post: (not empty)";
            // 
            // LastPostTextBox
            // 
            this.LastPostTextBox.Location = new System.Drawing.Point(278, 466);
            this.LastPostTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LastPostTextBox.Multiline = true;
            this.LastPostTextBox.Name = "LastPostTextBox";
            this.LastPostTextBox.ReadOnly = true;
            this.LastPostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LastPostTextBox.Size = new System.Drawing.Size(208, 186);
            this.LastPostTextBox.TabIndex = 49;
            // 
            // GroupsLinkLable
            // 
            this.GroupsLinkLable.AutoSize = true;
            this.GroupsLinkLable.Enabled = false;
            this.GroupsLinkLable.Location = new System.Drawing.Point(514, 174);
            this.GroupsLinkLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroupsLinkLable.Name = "GroupsLinkLable";
            this.GroupsLinkLable.Size = new System.Drawing.Size(94, 17);
            this.GroupsLinkLable.TabIndex = 46;
            this.GroupsLinkLable.TabStop = true;
            this.GroupsLinkLable.Text = "Fetch Groups";
            this.GroupsLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GroupsLinkLable_LinkClicked_1);
            // 
            // CoverPhotoPictureBox
            // 
            this.CoverPhotoPictureBox.Location = new System.Drawing.Point(470, 45);
            this.CoverPhotoPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CoverPhotoPictureBox.Name = "CoverPhotoPictureBox";
            this.CoverPhotoPictureBox.Size = new System.Drawing.Size(248, 125);
            this.CoverPhotoPictureBox.TabIndex = 50;
            this.CoverPhotoPictureBox.TabStop = false;
            // 
            // LikedPages
            // 
            this.LikedPages.AutoSize = true;
            this.LikedPages.Enabled = false;
            this.LikedPages.Location = new System.Drawing.Point(276, 174);
            this.LikedPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LikedPages.Name = "LikedPages";
            this.LikedPages.Size = new System.Drawing.Size(125, 17);
            this.LikedPages.TabIndex = 44;
            this.LikedPages.TabStop = true;
            this.LikedPages.Text = "Fetch Liked Pages";
            this.LikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LikedPages_LinkClicked_1);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(6, 66);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(155, 124);
            this.ProfilePictureBox.TabIndex = 40;
            this.ProfilePictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Location = new System.Drawing.Point(6, 20);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(138, 40);
            this.LoginButton.TabIndex = 39;
            this.LoginButton.Text = "&Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FecthFriendsLinkLabel
            // 
            this.FecthFriendsLinkLabel.AutoSize = true;
            this.FecthFriendsLinkLabel.Enabled = false;
            this.FecthFriendsLinkLabel.Location = new System.Drawing.Point(4, 256);
            this.FecthFriendsLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FecthFriendsLinkLabel.Name = "FecthFriendsLinkLabel";
            this.FecthFriendsLinkLabel.Size = new System.Drawing.Size(94, 17);
            this.FecthFriendsLinkLabel.TabIndex = 41;
            this.FecthFriendsLinkLabel.TabStop = true;
            this.FecthFriendsLinkLabel.Text = "Fetch Friends";
            this.FecthFriendsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FecthFriendsLinkLabel_LinkClicked);
            // 
            // FriendsTextBox
            // 
            this.FriendsTextBox.Location = new System.Drawing.Point(6, 286);
            this.FriendsTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FriendsTextBox.Multiline = true;
            this.FriendsTextBox.Name = "FriendsTextBox";
            this.FriendsTextBox.ReadOnly = true;
            this.FriendsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FriendsTextBox.Size = new System.Drawing.Size(198, 365);
            this.FriendsTextBox.TabIndex = 42;
            // 
            // LikedPagesTextBox
            // 
            this.LikedPagesTextBox.Location = new System.Drawing.Point(278, 211);
            this.LikedPagesTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LikedPagesTextBox.Multiline = true;
            this.LikedPagesTextBox.Name = "LikedPagesTextBox";
            this.LikedPagesTextBox.ReadOnly = true;
            this.LikedPagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LikedPagesTextBox.Size = new System.Drawing.Size(208, 184);
            this.LikedPagesTextBox.TabIndex = 45;
            // 
            // FetchCoverPhotoLinkLabel
            // 
            this.FetchCoverPhotoLinkLabel.AutoSize = true;
            this.FetchCoverPhotoLinkLabel.Enabled = false;
            this.FetchCoverPhotoLinkLabel.Location = new System.Drawing.Point(468, 20);
            this.FetchCoverPhotoLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FetchCoverPhotoLinkLabel.Name = "FetchCoverPhotoLinkLabel";
            this.FetchCoverPhotoLinkLabel.Size = new System.Drawing.Size(125, 17);
            this.FetchCoverPhotoLinkLabel.TabIndex = 43;
            this.FetchCoverPhotoLinkLabel.TabStop = true;
            this.FetchCoverPhotoLinkLabel.Text = "Fetch Cover Photo";
            this.FetchCoverPhotoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FetchCoverPhotoLinkLabel_LinkClicked);
            // 
            // GroupsTextBox
            // 
            this.GroupsTextBox.Location = new System.Drawing.Point(516, 211);
            this.GroupsTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.GroupsTextBox.Multiline = true;
            this.GroupsTextBox.Name = "GroupsTextBox";
            this.GroupsTextBox.ReadOnly = true;
            this.GroupsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GroupsTextBox.Size = new System.Drawing.Size(214, 184);
            this.GroupsTextBox.TabIndex = 47;
            // 
            // PackageSelectButton
            // 
            this.PackageSelectButton.BackColor = System.Drawing.Color.Gold;
            this.PackageSelectButton.Enabled = false;
            this.PackageSelectButton.Location = new System.Drawing.Point(278, 25);
            this.PackageSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.PackageSelectButton.Name = "PackageSelectButton";
            this.PackageSelectButton.Size = new System.Drawing.Size(152, 30);
            this.PackageSelectButton.TabIndex = 56;
            this.PackageSelectButton.Text = "Select Package";
            this.PackageSelectButton.UseVisualStyleBackColor = false;
            this.PackageSelectButton.Click += new System.EventHandler(this.PackageSelectButton_Click);
            // 
            // DanceButton
            // 
            this.DanceButton.Enabled = false;
            this.DanceButton.Location = new System.Drawing.Point(168, 68);
            this.DanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.DanceButton.Name = "DanceButton";
            this.DanceButton.Size = new System.Drawing.Size(94, 29);
            this.DanceButton.TabIndex = 57;
            this.DanceButton.Text = "Let\'s Dance";
            this.DanceButton.UseVisualStyleBackColor = true;
            this.DanceButton.Click += new System.EventHandler(this.DanceButton_Click);
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.Enabled = false;
            this.SortByComboBox.FormattingEnabled = true;
            this.SortByComboBox.Items.AddRange(new object[] {
            "Alphabetical",
            "Age",
            "Date",
            "Random"});
            this.SortByComboBox.Location = new System.Drawing.Point(103, 253);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(101, 24);
            this.SortByComboBox.TabIndex = 58;
            this.SortByComboBox.SelectionChangeCommitted += new System.EventHandler(this.SortByComboBox_SelectionChangeCommitted);
            // 
            // SortFriednsByLabel
            // 
            this.SortFriednsByLabel.AutoSize = true;
            this.SortFriednsByLabel.Enabled = false;
            this.SortFriednsByLabel.Location = new System.Drawing.Point(103, 233);
            this.SortFriednsByLabel.Name = "SortFriednsByLabel";
            this.SortFriednsByLabel.Size = new System.Drawing.Size(58, 17);
            this.SortFriednsByLabel.TabIndex = 59;
            this.SortFriednsByLabel.Text = "Sort By:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 672);
            this.Controls.Add(this.SortFriednsByLabel);
            this.Controls.Add(this.SortByComboBox);
            this.Controls.Add(this.DanceButton);
            this.Controls.Add(this.PackageSelectButton);
            this.Controls.Add(this.CheckInToRouteButton);
            this.Controls.Add(this.PictureToAsciiButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.EventsLinkLabel);
            this.Controls.Add(this.EventTextBox);
            this.Controls.Add(this.LastPostLabel);
            this.Controls.Add(this.LastPostTextBox);
            this.Controls.Add(this.GroupsLinkLable);
            this.Controls.Add(this.CoverPhotoPictureBox);
            this.Controls.Add(this.LikedPages);
            this.Controls.Add(this.ProfilePictureBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.FecthFriendsLinkLabel);
            this.Controls.Add(this.FriendsTextBox);
            this.Controls.Add(this.LikedPagesTextBox);
            this.Controls.Add(this.FetchCoverPhotoLinkLabel);
            this.Controls.Add(this.GroupsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acebook D&G app";
            ((System.ComponentModel.ISupportInitialize)(this.CoverPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button CheckInToRouteButton;
        private System.Windows.Forms.Button PictureToAsciiButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.LinkLabel EventsLinkLabel;
        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.Label LastPostLabel;
        private System.Windows.Forms.TextBox LastPostTextBox;
        private System.Windows.Forms.LinkLabel GroupsLinkLable;
        private System.Windows.Forms.PictureBox CoverPhotoPictureBox;
        private System.Windows.Forms.LinkLabel LikedPages;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel FecthFriendsLinkLabel;
        private System.Windows.Forms.TextBox FriendsTextBox;
        private System.Windows.Forms.TextBox LikedPagesTextBox;
        private System.Windows.Forms.LinkLabel FetchCoverPhotoLinkLabel;
        private System.Windows.Forms.TextBox GroupsTextBox;
        private System.Windows.Forms.Button PackageSelectButton;
        private System.Windows.Forms.Button DanceButton;
        private System.Windows.Forms.ComboBox SortByComboBox;
        private System.Windows.Forms.Label SortFriednsByLabel;
    }
}
