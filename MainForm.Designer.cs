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
            this.LoginButton = new System.Windows.Forms.Button();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.FecthFriendsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FriendsTextBox = new System.Windows.Forms.TextBox();
            this.FetchCoverPhotoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GroupsTextBox = new System.Windows.Forms.TextBox();
            this.GroupsLinkLable = new System.Windows.Forms.LinkLabel();
            this.LikedPagesTextBox = new System.Windows.Forms.TextBox();
            this.LikedPages = new System.Windows.Forms.LinkLabel();
            this.LastPostLabel = new System.Windows.Forms.Label();
            this.LastPostTextBox = new System.Windows.Forms.TextBox();
            this.FetchCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.MainFacebookApp = new System.Windows.Forms.TabControl();
            this.MainAppTab = new System.Windows.Forms.TabPage();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EventsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.PictureToAsciiTab = new System.Windows.Forms.TabPage();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.AsciiStringTextBox = new System.Windows.Forms.TextBox();
            this.PictureToAsciiSettingsButton = new System.Windows.Forms.Button();
            this.PictureToAsciiButton = new System.Windows.Forms.Button();
            this.CheckInToRouteTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectWayPointButton = new System.Windows.Forms.Button();
            this.CheckInToRouteButton = new System.Windows.Forms.Button();
            this.StopsLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.NumberOfStopsComboBox = new System.Windows.Forms.ComboBox();
            this.DestinationComboBox = new System.Windows.Forms.ComboBox();
            this.OriginComboBox = new System.Windows.Forms.ComboBox();
            this.CheckInRouteInfoLabel = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FetchCoverPictureBox)).BeginInit();
            this.MainFacebookApp.SuspendLayout();
            this.MainAppTab.SuspendLayout();
            this.PictureToAsciiTab.SuspendLayout();
            this.CheckInToRouteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Location = new System.Drawing.Point(15, 28);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(138, 40);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "&Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Clicked);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(15, 74);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(235, 176);
            this.ProfilePictureBox.TabIndex = 2;
            this.ProfilePictureBox.TabStop = false;
            // 
            // FecthFriendsLinkLabel
            // 
            this.FecthFriendsLinkLabel.AutoSize = true;
            this.FecthFriendsLinkLabel.Enabled = false;
            this.FecthFriendsLinkLabel.Location = new System.Drawing.Point(12, 268);
            this.FecthFriendsLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FecthFriendsLinkLabel.Name = "FecthFriendsLinkLabel";
            this.FecthFriendsLinkLabel.Size = new System.Drawing.Size(94, 17);
            this.FecthFriendsLinkLabel.TabIndex = 4;
            this.FecthFriendsLinkLabel.TabStop = true;
            this.FecthFriendsLinkLabel.Text = "Fetch Friends";
            this.FecthFriendsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FriendsLinkLabel_LinkClicked);
            // 
            // FriendsTextBox
            // 
            this.FriendsTextBox.Location = new System.Drawing.Point(15, 305);
            this.FriendsTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FriendsTextBox.Multiline = true;
            this.FriendsTextBox.Name = "FriendsTextBox";
            this.FriendsTextBox.ReadOnly = true;
            this.FriendsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FriendsTextBox.Size = new System.Drawing.Size(224, 298);
            this.FriendsTextBox.TabIndex = 5;
            // 
            // FetchCoverPhotoLinkLabel
            // 
            this.FetchCoverPhotoLinkLabel.AutoSize = true;
            this.FetchCoverPhotoLinkLabel.Enabled = false;
            this.FetchCoverPhotoLinkLabel.Location = new System.Drawing.Point(585, 28);
            this.FetchCoverPhotoLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FetchCoverPhotoLinkLabel.Name = "FetchCoverPhotoLinkLabel";
            this.FetchCoverPhotoLinkLabel.Size = new System.Drawing.Size(125, 17);
            this.FetchCoverPhotoLinkLabel.TabIndex = 6;
            this.FetchCoverPhotoLinkLabel.TabStop = true;
            this.FetchCoverPhotoLinkLabel.Text = "Fetch Cover Photo";
            this.FetchCoverPhotoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CoverPhotoLinkLabel_LinkClicked);
            // 
            // GroupsTextBox
            // 
            this.GroupsTextBox.Location = new System.Drawing.Point(641, 305);
            this.GroupsTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.GroupsTextBox.Multiline = true;
            this.GroupsTextBox.Name = "GroupsTextBox";
            this.GroupsTextBox.ReadOnly = true;
            this.GroupsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GroupsTextBox.Size = new System.Drawing.Size(240, 298);
            this.GroupsTextBox.TabIndex = 11;
            // 
            // GroupsLinkLable
            // 
            this.GroupsLinkLable.AutoSize = true;
            this.GroupsLinkLable.Enabled = false;
            this.GroupsLinkLable.Location = new System.Drawing.Point(638, 268);
            this.GroupsLinkLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroupsLinkLable.Name = "GroupsLinkLable";
            this.GroupsLinkLable.Size = new System.Drawing.Size(94, 17);
            this.GroupsLinkLable.TabIndex = 10;
            this.GroupsLinkLable.TabStop = true;
            this.GroupsLinkLable.Text = "Fetch Groups";
            this.GroupsLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GroupsLinkLable_LinkClicked);
            // 
            // LikedPagesTextBox
            // 
            this.LikedPagesTextBox.Location = new System.Drawing.Point(315, 305);
            this.LikedPagesTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LikedPagesTextBox.Multiline = true;
            this.LikedPagesTextBox.Name = "LikedPagesTextBox";
            this.LikedPagesTextBox.ReadOnly = true;
            this.LikedPagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LikedPagesTextBox.Size = new System.Drawing.Size(234, 298);
            this.LikedPagesTextBox.TabIndex = 9;
            // 
            // LikedPages
            // 
            this.LikedPages.AutoSize = true;
            this.LikedPages.Enabled = false;
            this.LikedPages.Location = new System.Drawing.Point(311, 268);
            this.LikedPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LikedPages.Name = "LikedPages";
            this.LikedPages.Size = new System.Drawing.Size(125, 17);
            this.LikedPages.TabIndex = 8;
            this.LikedPages.TabStop = true;
            this.LikedPages.Text = "Fetch Liked Pages";
            this.LikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LikedPages_LinkClicked);
            // 
            // LastPostLabel
            // 
            this.LastPostLabel.AutoSize = true;
            this.LastPostLabel.Location = new System.Drawing.Point(12, 634);
            this.LastPostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastPostLabel.Name = "LastPostLabel";
            this.LastPostLabel.Size = new System.Drawing.Size(147, 17);
            this.LastPostLabel.TabIndex = 12;
            this.LastPostLabel.Text = "Last Post: (not empty)";
            // 
            // LastPostTextBox
            // 
            this.LastPostTextBox.Location = new System.Drawing.Point(16, 665);
            this.LastPostTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LastPostTextBox.Multiline = true;
            this.LastPostTextBox.Name = "LastPostTextBox";
            this.LastPostTextBox.ReadOnly = true;
            this.LastPostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LastPostTextBox.Size = new System.Drawing.Size(360, 184);
            this.LastPostTextBox.TabIndex = 13;
            // 
            // FetchCoverPictureBox
            // 
            this.FetchCoverPictureBox.Location = new System.Drawing.Point(589, 68);
            this.FetchCoverPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FetchCoverPictureBox.Name = "FetchCoverPictureBox";
            this.FetchCoverPictureBox.Size = new System.Drawing.Size(294, 182);
            this.FetchCoverPictureBox.TabIndex = 16;
            this.FetchCoverPictureBox.TabStop = false;
            // 
            // MainFacebookApp
            // 
            this.MainFacebookApp.Controls.Add(this.MainAppTab);
            this.MainFacebookApp.Controls.Add(this.PictureToAsciiTab);
            this.MainFacebookApp.Controls.Add(this.CheckInToRouteTab);
            this.MainFacebookApp.Location = new System.Drawing.Point(0, 0);
            this.MainFacebookApp.Margin = new System.Windows.Forms.Padding(4);
            this.MainFacebookApp.Name = "MainFacebookApp";
            this.MainFacebookApp.SelectedIndex = 0;
            this.MainFacebookApp.Size = new System.Drawing.Size(959, 942);
            this.MainFacebookApp.TabIndex = 17;
            // 
            // MainAppTab
            // 
            this.MainAppTab.AutoScroll = true;
            this.MainAppTab.Controls.Add(this.LogoutButton);
            this.MainAppTab.Controls.Add(this.EventsLinkLabel);
            this.MainAppTab.Controls.Add(this.EventTextBox);
            this.MainAppTab.Controls.Add(this.LastPostLabel);
            this.MainAppTab.Controls.Add(this.LastPostTextBox);
            this.MainAppTab.Controls.Add(this.GroupsLinkLable);
            this.MainAppTab.Controls.Add(this.FetchCoverPictureBox);
            this.MainAppTab.Controls.Add(this.LikedPages);
            this.MainAppTab.Controls.Add(this.ProfilePictureBox);
            this.MainAppTab.Controls.Add(this.LoginButton);
            this.MainAppTab.Controls.Add(this.FecthFriendsLinkLabel);
            this.MainAppTab.Controls.Add(this.FriendsTextBox);
            this.MainAppTab.Controls.Add(this.LikedPagesTextBox);
            this.MainAppTab.Controls.Add(this.FetchCoverPhotoLinkLabel);
            this.MainAppTab.Controls.Add(this.GroupsTextBox);
            this.MainAppTab.Location = new System.Drawing.Point(4, 25);
            this.MainAppTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainAppTab.Name = "MainAppTab";
            this.MainAppTab.Padding = new System.Windows.Forms.Padding(4);
            this.MainAppTab.Size = new System.Drawing.Size(951, 913);
            this.MainAppTab.TabIndex = 0;
            this.MainAppTab.Text = "Main App";
            this.MainAppTab.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.RosyBrown;
            this.LogoutButton.Location = new System.Drawing.Point(175, 38);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 29);
            this.LogoutButton.TabIndex = 19;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EventsLinkLabel
            // 
            this.EventsLinkLabel.AutoSize = true;
            this.EventsLinkLabel.Enabled = false;
            this.EventsLinkLabel.Location = new System.Drawing.Point(518, 634);
            this.EventsLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventsLinkLabel.Name = "EventsLinkLabel";
            this.EventsLinkLabel.Size = new System.Drawing.Size(90, 17);
            this.EventsLinkLabel.TabIndex = 18;
            this.EventsLinkLabel.TabStop = true;
            this.EventsLinkLabel.Text = "Fetch Events";
            this.EventsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EventsLinkLabel_LinkClicked);
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(521, 665);
            this.EventTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EventTextBox.Multiline = true;
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.ReadOnly = true;
            this.EventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EventTextBox.Size = new System.Drawing.Size(360, 184);
            this.EventTextBox.TabIndex = 17;
            // 
            // PictureToAsciiTab
            // 
            this.PictureToAsciiTab.Controls.Add(this.SaveToFileButton);
            this.PictureToAsciiTab.Controls.Add(this.AsciiStringTextBox);
            this.PictureToAsciiTab.Controls.Add(this.PictureToAsciiSettingsButton);
            this.PictureToAsciiTab.Controls.Add(this.PictureToAsciiButton);
            this.PictureToAsciiTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureToAsciiTab.Location = new System.Drawing.Point(4, 25);
            this.PictureToAsciiTab.Margin = new System.Windows.Forms.Padding(4);
            this.PictureToAsciiTab.Name = "PictureToAsciiTab";
            this.PictureToAsciiTab.Padding = new System.Windows.Forms.Padding(4);
            this.PictureToAsciiTab.Size = new System.Drawing.Size(951, 913);
            this.PictureToAsciiTab.TabIndex = 1;
            this.PictureToAsciiTab.Text = "Profile To Ascii";
            this.PictureToAsciiTab.UseVisualStyleBackColor = true;
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Enabled = false;
            this.SaveToFileButton.Location = new System.Drawing.Point(592, 22);
            this.SaveToFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(218, 40);
            this.SaveToFileButton.TabIndex = 3;
            this.SaveToFileButton.Text = "Save To &file";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // AsciiStringTextBox
            // 
            this.AsciiStringTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsciiStringTextBox.Location = new System.Drawing.Point(10, 111);
            this.AsciiStringTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AsciiStringTextBox.Multiline = true;
            this.AsciiStringTextBox.Name = "AsciiStringTextBox";
            this.AsciiStringTextBox.ReadOnly = true;
            this.AsciiStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AsciiStringTextBox.Size = new System.Drawing.Size(908, 793);
            this.AsciiStringTextBox.TabIndex = 2;
            // 
            // PictureToAsciiSettingsButton
            // 
            this.PictureToAsciiSettingsButton.Enabled = false;
            this.PictureToAsciiSettingsButton.Location = new System.Drawing.Point(299, 22);
            this.PictureToAsciiSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.PictureToAsciiSettingsButton.Name = "PictureToAsciiSettingsButton";
            this.PictureToAsciiSettingsButton.Size = new System.Drawing.Size(218, 40);
            this.PictureToAsciiSettingsButton.TabIndex = 1;
            this.PictureToAsciiSettingsButton.Text = "&Settings";
            this.PictureToAsciiSettingsButton.UseVisualStyleBackColor = true;
            this.PictureToAsciiSettingsButton.Click += new System.EventHandler(this.PictureToAsciiSettingsButton_Click);
            // 
            // PictureToAsciiButton
            // 
            this.PictureToAsciiButton.BackColor = System.Drawing.Color.LightGreen;
            this.PictureToAsciiButton.Enabled = false;
            this.PictureToAsciiButton.Location = new System.Drawing.Point(15, 22);
            this.PictureToAsciiButton.Margin = new System.Windows.Forms.Padding(4);
            this.PictureToAsciiButton.Name = "PictureToAsciiButton";
            this.PictureToAsciiButton.Size = new System.Drawing.Size(218, 40);
            this.PictureToAsciiButton.TabIndex = 0;
            this.PictureToAsciiButton.Text = "Make Profile Picture To Ascii";
            this.PictureToAsciiButton.UseVisualStyleBackColor = false;
            this.PictureToAsciiButton.Click += new System.EventHandler(this.PictureToAsciiButton_Click);
            // 
            // CheckInToRouteTab
            // 
            this.CheckInToRouteTab.Controls.Add(this.label1);
            this.CheckInToRouteTab.Controls.Add(this.SelectWayPointButton);
            this.CheckInToRouteTab.Controls.Add(this.CheckInToRouteButton);
            this.CheckInToRouteTab.Controls.Add(this.StopsLabel);
            this.CheckInToRouteTab.Controls.Add(this.DestinationLabel);
            this.CheckInToRouteTab.Controls.Add(this.OriginLabel);
            this.CheckInToRouteTab.Controls.Add(this.NumberOfStopsComboBox);
            this.CheckInToRouteTab.Controls.Add(this.DestinationComboBox);
            this.CheckInToRouteTab.Controls.Add(this.OriginComboBox);
            this.CheckInToRouteTab.Controls.Add(this.CheckInRouteInfoLabel);
            this.CheckInToRouteTab.Location = new System.Drawing.Point(4, 25);
            this.CheckInToRouteTab.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInToRouteTab.Name = "CheckInToRouteTab";
            this.CheckInToRouteTab.Size = new System.Drawing.Size(951, 913);
            this.CheckInToRouteTab.TabIndex = 2;
            this.CheckInToRouteTab.Text = "CheckIn To Route";
            this.CheckInToRouteTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 85);
            this.label1.TabIndex = 11;
            this.label1.Text = "This feature creates a path \r\nin google maps with all your checkin, \r\nplease sele" +
    "ct where you want to start the path\r\n and where to finish it.\r\nYou can choose up" +
    " to 9 stops along the way.\r\n";
            // 
            // SelectWayPointButton
            // 
            this.SelectWayPointButton.Enabled = false;
            this.SelectWayPointButton.Location = new System.Drawing.Point(37, 379);
            this.SelectWayPointButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectWayPointButton.Name = "SelectWayPointButton";
            this.SelectWayPointButton.Size = new System.Drawing.Size(197, 28);
            this.SelectWayPointButton.TabIndex = 10;
            this.SelectWayPointButton.Text = "Select Way Points";
            this.SelectWayPointButton.UseVisualStyleBackColor = true;
            this.SelectWayPointButton.Click += new System.EventHandler(this.SelectWayPointButton_Click);
            // 
            // CheckInToRouteButton
            // 
            this.CheckInToRouteButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckInToRouteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckInToRouteButton.BackgroundImage")));
            this.CheckInToRouteButton.Enabled = false;
            this.CheckInToRouteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInToRouteButton.Location = new System.Drawing.Point(394, 502);
            this.CheckInToRouteButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInToRouteButton.Name = "CheckInToRouteButton";
            this.CheckInToRouteButton.Size = new System.Drawing.Size(204, 57);
            this.CheckInToRouteButton.TabIndex = 9;
            this.CheckInToRouteButton.Text = "Get Route from Checkings";
            this.CheckInToRouteButton.UseVisualStyleBackColor = false;
            this.CheckInToRouteButton.Click += new System.EventHandler(this.CheckInToRouteButton_Click);
            // 
            // StopsLabel
            // 
            this.StopsLabel.AutoSize = true;
            this.StopsLabel.Location = new System.Drawing.Point(34, 211);
            this.StopsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StopsLabel.Name = "StopsLabel";
            this.StopsLabel.Size = new System.Drawing.Size(173, 17);
            this.StopsLabel.TabIndex = 8;
            this.StopsLabel.Text = "Choose Number Of Stops:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(34, 116);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(135, 17);
            this.DestinationLabel.TabIndex = 7;
            this.DestinationLabel.Text = "Choose Destination:";
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(34, 39);
            this.OriginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(102, 17);
            this.OriginLabel.TabIndex = 6;
            this.OriginLabel.Text = "Choose Origin:";
            // 
            // NumberOfStopsComboBox
            // 
            this.NumberOfStopsComboBox.Enabled = false;
            this.NumberOfStopsComboBox.FormattingEnabled = true;
            this.NumberOfStopsComboBox.Location = new System.Drawing.Point(37, 253);
            this.NumberOfStopsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfStopsComboBox.Name = "NumberOfStopsComboBox";
            this.NumberOfStopsComboBox.Size = new System.Drawing.Size(604, 24);
            this.NumberOfStopsComboBox.TabIndex = 5;
            // 
            // DestinationComboBox
            // 
            this.DestinationComboBox.Enabled = false;
            this.DestinationComboBox.FormattingEnabled = true;
            this.DestinationComboBox.Location = new System.Drawing.Point(38, 158);
            this.DestinationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationComboBox.Name = "DestinationComboBox";
            this.DestinationComboBox.Size = new System.Drawing.Size(604, 24);
            this.DestinationComboBox.TabIndex = 4;
            // 
            // OriginComboBox
            // 
            this.OriginComboBox.Enabled = false;
            this.OriginComboBox.FormattingEnabled = true;
            this.OriginComboBox.Location = new System.Drawing.Point(38, 70);
            this.OriginComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OriginComboBox.Name = "OriginComboBox";
            this.OriginComboBox.Size = new System.Drawing.Size(604, 24);
            this.OriginComboBox.TabIndex = 3;
            // 
            // CheckInRouteInfoLabel
            // 
            this.CheckInRouteInfoLabel.AutoSize = true;
            this.CheckInRouteInfoLabel.Location = new System.Drawing.Point(35, 314);
            this.CheckInRouteInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckInRouteInfoLabel.Name = "CheckInRouteInfoLabel";
            this.CheckInRouteInfoLabel.Size = new System.Drawing.Size(204, 34);
            this.CheckInRouteInfoLabel.TabIndex = 1;
            this.CheckInRouteInfoLabel.Text = "Please check the places \r\nthat you want to see a route of:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(956, 704);
            this.Controls.Add(this.MainFacebookApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acebook D&G app";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FetchCoverPictureBox)).EndInit();
            this.MainFacebookApp.ResumeLayout(false);
            this.MainAppTab.ResumeLayout(false);
            this.MainAppTab.PerformLayout();
            this.PictureToAsciiTab.ResumeLayout(false);
            this.PictureToAsciiTab.PerformLayout();
            this.CheckInToRouteTab.ResumeLayout(false);
            this.CheckInToRouteTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.LinkLabel FecthFriendsLinkLabel;
        private System.Windows.Forms.TextBox FriendsTextBox;
        private System.Windows.Forms.LinkLabel FetchCoverPhotoLinkLabel;
        private System.Windows.Forms.TextBox GroupsTextBox;
        private System.Windows.Forms.LinkLabel GroupsLinkLable;
        private System.Windows.Forms.TextBox LikedPagesTextBox;
        private System.Windows.Forms.LinkLabel LikedPages;
        private System.Windows.Forms.Label LastPostLabel;
        private System.Windows.Forms.TextBox LastPostTextBox;
        private System.Windows.Forms.PictureBox FetchCoverPictureBox;
        private System.Windows.Forms.TabControl MainFacebookApp;
        private System.Windows.Forms.TabPage MainAppTab;
        private System.Windows.Forms.TabPage PictureToAsciiTab;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.TextBox AsciiStringTextBox;
        private System.Windows.Forms.Button PictureToAsciiSettingsButton;
        private System.Windows.Forms.Button PictureToAsciiButton;
        private System.Windows.Forms.TabPage CheckInToRouteTab;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.LinkLabel EventsLinkLabel;
        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.Label CheckInRouteInfoLabel;
        private System.Windows.Forms.Label StopsLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.ComboBox NumberOfStopsComboBox;
        private System.Windows.Forms.ComboBox DestinationComboBox;
        private System.Windows.Forms.ComboBox OriginComboBox;
        private System.Windows.Forms.Button CheckInToRouteButton;
        private System.Windows.Forms.Button SelectWayPointButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
    }
}
