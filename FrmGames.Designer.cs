namespace GameLauncher
{
    partial class FrmGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGames));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTGName = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.gbxUserInfos = new System.Windows.Forms.GroupBox();
            this.lblUUAge = new System.Windows.Forms.Label();
            this.lblUserAge = new System.Windows.Forms.Label();
            this.lblUUName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlFull = new System.Windows.Forms.Panel();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabcGG = new System.Windows.Forms.TabControl();
            this.tabpDetails = new System.Windows.Forms.TabPage();
            this.lblGGReviewSummery = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblGGRealseDate = new System.Windows.Forms.Label();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.lblGGDeveloper = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblGGName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabpDescription = new System.Windows.Forms.TabPage();
            this.wbrGGDesription = new System.Windows.Forms.WebBrowser();
            this.tabPictures = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxGGIcon = new System.Windows.Forms.PictureBox();
            this.pbxGGAge = new System.Windows.Forms.PictureBox();
            this.btnFav = new System.Windows.Forms.Button();
            this.lblGGLastPlayed = new System.Windows.Forms.Label();
            this.lblLPlay = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lbxAllGames = new System.Windows.Forms.ListBox();
            this.pnlTop.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.gbxUserInfos.SuspendLayout();
            this.pnlFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.tabcGG.SuspendLayout();
            this.tabpDetails.SuspendLayout();
            this.tabpDescription.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGGIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGGAge)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTGName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(932, 55);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTGName
            // 
            this.lblTGName.AutoSize = true;
            this.lblTGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGName.Location = new System.Drawing.Point(496, 15);
            this.lblTGName.Name = "lblTGName";
            this.lblTGName.Size = new System.Drawing.Size(173, 33);
            this.lblTGName.TabIndex = 0;
            this.lblTGName.Text = "GameName";
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.gbxUserInfos);
            this.pnlBot.Controls.Add(this.btnLogOut);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 827);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(932, 84);
            this.pnlBot.TabIndex = 2;
            // 
            // gbxUserInfos
            // 
            this.gbxUserInfos.Controls.Add(this.lblUUAge);
            this.gbxUserInfos.Controls.Add(this.lblUserAge);
            this.gbxUserInfos.Controls.Add(this.lblUUName);
            this.gbxUserInfos.Controls.Add(this.lblUserName);
            this.gbxUserInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUserInfos.Location = new System.Drawing.Point(12, 14);
            this.gbxUserInfos.Name = "gbxUserInfos";
            this.gbxUserInfos.Size = new System.Drawing.Size(368, 58);
            this.gbxUserInfos.TabIndex = 1;
            this.gbxUserInfos.TabStop = false;
            this.gbxUserInfos.Text = "User information";
            // 
            // lblUUAge
            // 
            this.lblUUAge.AutoSize = true;
            this.lblUUAge.Location = new System.Drawing.Point(322, 26);
            this.lblUUAge.Name = "lblUUAge";
            this.lblUUAge.Size = new System.Drawing.Size(27, 20);
            this.lblUUAge.TabIndex = 3;
            this.lblUUAge.Text = "18";
            // 
            // lblUserAge
            // 
            this.lblUserAge.AutoSize = true;
            this.lblUserAge.Location = new System.Drawing.Point(240, 26);
            this.lblUserAge.Name = "lblUserAge";
            this.lblUserAge.Size = new System.Drawing.Size(46, 20);
            this.lblUserAge.TabIndex = 2;
            this.lblUserAge.Text = "Age :";
            // 
            // lblUUName
            // 
            this.lblUUName.AutoSize = true;
            this.lblUUName.Location = new System.Drawing.Point(99, 26);
            this.lblUUName.Name = "lblUUName";
            this.lblUUName.Size = new System.Drawing.Size(135, 20);
            this.lblUUName.TabIndex = 1;
            this.lblUUName.Text = "Sebastian Kiebert";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Name :";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(769, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 45);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlFull
            // 
            this.pnlFull.Controls.Add(this.windowsMediaPlayer);
            this.pnlFull.Controls.Add(this.tabcGG);
            this.pnlFull.Controls.Add(this.panel1);
            this.pnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFull.Location = new System.Drawing.Point(246, 55);
            this.pnlFull.Name = "pnlFull";
            this.pnlFull.Size = new System.Drawing.Size(686, 772);
            this.pnlFull.TabIndex = 3;
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(686, 407);
            this.windowsMediaPlayer.TabIndex = 4;
            // 
            // tabcGG
            // 
            this.tabcGG.Controls.Add(this.tabpDetails);
            this.tabcGG.Controls.Add(this.tabpDescription);
            this.tabcGG.Controls.Add(this.tabPictures);
            this.tabcGG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabcGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcGG.Location = new System.Drawing.Point(0, 492);
            this.tabcGG.Name = "tabcGG";
            this.tabcGG.SelectedIndex = 0;
            this.tabcGG.Size = new System.Drawing.Size(686, 280);
            this.tabcGG.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabcGG.TabIndex = 3;
            this.tabcGG.SelectedIndexChanged += new System.EventHandler(this.tabcGG_SelectedIndexChanged);
            // 
            // tabpDetails
            // 
            this.tabpDetails.Controls.Add(this.lblGGReviewSummery);
            this.tabpDetails.Controls.Add(this.lblReview);
            this.tabpDetails.Controls.Add(this.lblGGRealseDate);
            this.tabpDetails.Controls.Add(this.lbReleaseDate);
            this.tabpDetails.Controls.Add(this.lblGGDeveloper);
            this.tabpDetails.Controls.Add(this.lblDeveloper);
            this.tabpDetails.Controls.Add(this.lblGGName);
            this.tabpDetails.Controls.Add(this.lblName);
            this.tabpDetails.Location = new System.Drawing.Point(4, 25);
            this.tabpDetails.Name = "tabpDetails";
            this.tabpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetails.Size = new System.Drawing.Size(678, 251);
            this.tabpDetails.TabIndex = 0;
            this.tabpDetails.Text = "Details";
            this.tabpDetails.UseVisualStyleBackColor = true;
            // 
            // lblGGReviewSummery
            // 
            this.lblGGReviewSummery.AutoSize = true;
            this.lblGGReviewSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGGReviewSummery.Location = new System.Drawing.Point(430, 204);
            this.lblGGReviewSummery.Name = "lblGGReviewSummery";
            this.lblGGReviewSummery.Size = new System.Drawing.Size(90, 20);
            this.lblGGReviewSummery.TabIndex = 7;
            this.lblGGReviewSummery.Text = "Pretty good";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(36, 206);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(169, 18);
            this.lblReview.TabIndex = 6;
            this.lblReview.Text = "Game Review Summery";
            // 
            // lblGGRealseDate
            // 
            this.lblGGRealseDate.AutoSize = true;
            this.lblGGRealseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGGRealseDate.Location = new System.Drawing.Point(430, 160);
            this.lblGGRealseDate.Name = "lblGGRealseDate";
            this.lblGGRealseDate.Size = new System.Drawing.Size(102, 20);
            this.lblGGRealseDate.TabIndex = 5;
            this.lblGGRealseDate.Text = "Nov 16, 2918";
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleaseDate.Location = new System.Drawing.Point(36, 160);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(107, 20);
            this.lbReleaseDate.TabIndex = 4;
            this.lbReleaseDate.Text = "Release Date";
            // 
            // lblGGDeveloper
            // 
            this.lblGGDeveloper.AutoSize = true;
            this.lblGGDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGGDeveloper.Location = new System.Drawing.Point(430, 109);
            this.lblGGDeveloper.Name = "lblGGDeveloper";
            this.lblGGDeveloper.Size = new System.Drawing.Size(80, 20);
            this.lblGGDeveloper.TabIndex = 3;
            this.lblGGDeveloper.Text = "Innersloth";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(36, 109);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(127, 20);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Developer Name";
            // 
            // lblGGName
            // 
            this.lblGGName.AutoSize = true;
            this.lblGGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGGName.Location = new System.Drawing.Point(430, 59);
            this.lblGGName.Name = "lblGGName";
            this.lblGGName.Size = new System.Drawing.Size(84, 20);
            this.lblGGName.TabIndex = 1;
            this.lblGGName.Text = "Among Us";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tabpDescription
            // 
            this.tabpDescription.Controls.Add(this.wbrGGDesription);
            this.tabpDescription.Location = new System.Drawing.Point(4, 25);
            this.tabpDescription.Name = "tabpDescription";
            this.tabpDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDescription.Size = new System.Drawing.Size(678, 251);
            this.tabpDescription.TabIndex = 1;
            this.tabpDescription.Text = "Description";
            this.tabpDescription.UseVisualStyleBackColor = true;
            // 
            // wbrGGDesription
            // 
            this.wbrGGDesription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrGGDesription.Location = new System.Drawing.Point(3, 3);
            this.wbrGGDesription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrGGDesription.Name = "wbrGGDesription";
            this.wbrGGDesription.Size = new System.Drawing.Size(672, 245);
            this.wbrGGDesription.TabIndex = 0;
            // 
            // tabPictures
            // 
            this.tabPictures.Location = new System.Drawing.Point(4, 25);
            this.tabPictures.Name = "tabPictures";
            this.tabPictures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPictures.Size = new System.Drawing.Size(678, 251);
            this.tabPictures.TabIndex = 2;
            this.tabPictures.Text = "Pictures";
            this.tabPictures.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbxGGIcon);
            this.panel1.Controls.Add(this.pbxGGAge);
            this.panel1.Controls.Add(this.btnFav);
            this.panel1.Controls.Add(this.lblGGLastPlayed);
            this.panel1.Controls.Add(this.lblLPlay);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 79);
            this.panel1.TabIndex = 2;
            // 
            // pbxGGIcon
            // 
            this.pbxGGIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGGIcon.Location = new System.Drawing.Point(6, 6);
            this.pbxGGIcon.Name = "pbxGGIcon";
            this.pbxGGIcon.Size = new System.Drawing.Size(60, 60);
            this.pbxGGIcon.TabIndex = 6;
            this.pbxGGIcon.TabStop = false;
            // 
            // pbxGGAge
            // 
            this.pbxGGAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGGAge.Location = new System.Drawing.Point(530, 7);
            this.pbxGGAge.Name = "pbxGGAge";
            this.pbxGGAge.Size = new System.Drawing.Size(60, 60);
            this.pbxGGAge.TabIndex = 5;
            this.pbxGGAge.TabStop = false;
            // 
            // btnFav
            // 
            this.btnFav.BackgroundImage = global::GameLauncher.Properties.Resources.thumbsUpEmpty;
            this.btnFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFav.Location = new System.Drawing.Point(613, 7);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(61, 59);
            this.btnFav.TabIndex = 4;
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // lblGGLastPlayed
            // 
            this.lblGGLastPlayed.AutoSize = true;
            this.lblGGLastPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGGLastPlayed.Location = new System.Drawing.Point(352, 47);
            this.lblGGLastPlayed.Name = "lblGGLastPlayed";
            this.lblGGLastPlayed.Size = new System.Drawing.Size(50, 16);
            this.lblGGLastPlayed.TabIndex = 3;
            this.lblGGLastPlayed.Text = "Nov 29";
            // 
            // lblLPlay
            // 
            this.lblLPlay.AutoSize = true;
            this.lblLPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPlay.Location = new System.Drawing.Point(352, 18);
            this.lblLPlay.Name = "lblLPlay";
            this.lblLPlay.Size = new System.Drawing.Size(105, 18);
            this.lblLPlay.TabIndex = 2;
            this.lblLPlay.Text = "LAST PLAYED";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Gray;
            this.btnPlay.Location = new System.Drawing.Point(77, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(255, 64);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lbxAllGames);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 55);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(246, 772);
            this.pnlLeft.TabIndex = 4;
            // 
            // lbxAllGames
            // 
            this.lbxAllGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAllGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAllGames.FormattingEnabled = true;
            this.lbxAllGames.ItemHeight = 20;
            this.lbxAllGames.Location = new System.Drawing.Point(0, 0);
            this.lbxAllGames.Name = "lbxAllGames";
            this.lbxAllGames.Size = new System.Drawing.Size(246, 772);
            this.lbxAllGames.TabIndex = 0;
            this.lbxAllGames.SelectedIndexChanged += new System.EventHandler(this.lbxAllGames_SelectedIndexChanged);
            // 
            // FrmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 911);
            this.Controls.Add(this.pnlFull);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.Activated += new System.EventHandler(this.FrmGames_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGames_FormClosing);
            this.Shown += new System.EventHandler(this.FrmGames_Shown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBot.ResumeLayout(false);
            this.gbxUserInfos.ResumeLayout(false);
            this.gbxUserInfos.PerformLayout();
            this.pnlFull.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.tabcGG.ResumeLayout(false);
            this.tabpDetails.ResumeLayout(false);
            this.tabpDetails.PerformLayout();
            this.tabpDescription.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGGIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGGAge)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Label lblGGLastPlayed;
        private System.Windows.Forms.Label lblLPlay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ListBox lbxAllGames;
        private System.Windows.Forms.Label lblTGName;
        private System.Windows.Forms.TabControl tabcGG;
        private System.Windows.Forms.TabPage tabpDetails;
        private System.Windows.Forms.TabPage tabpDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGGReviewSummery;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblGGRealseDate;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.Label lblGGDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblGGName;
        private System.Windows.Forms.WebBrowser wbrGGDesription;
        private System.Windows.Forms.PictureBox pbxGGAge;
        private System.Windows.Forms.PictureBox pbxGGIcon;
        private System.Windows.Forms.GroupBox gbxUserInfos;
        private System.Windows.Forms.Label lblUUAge;
        private System.Windows.Forms.Label lblUserAge;
        private System.Windows.Forms.Label lblUUName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabPage tabPictures;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
    }
}

