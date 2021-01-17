namespace GameLauncher
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.lbxGames = new System.Windows.Forms.ListBox();
            this.llblLoadGames = new System.Windows.Forms.LinkLabel();
            this.pbrImports = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbtnEditUser = new System.Windows.Forms.RadioButton();
            this.rbtnEditGames = new System.Windows.Forms.RadioButton();
            this.pnlGames = new System.Windows.Forms.Panel();
            this.btnSearchForPossDescription = new System.Windows.Forms.Button();
            this.tbxReview = new System.Windows.Forms.TextBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.cmbxAge = new System.Windows.Forms.ComboBox();
            this.lblGamesCountDown = new System.Windows.Forms.Label();
            this.btnGameDelete = new System.Windows.Forms.Button();
            this.btnGameAdd = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnChangeGame = new System.Windows.Forms.Button();
            this.btnPathChange = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.tbxReleaseDate = new System.Windows.Forms.TextBox();
            this.tbxDeveloper = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.wbrsDescription = new System.Windows.Forms.WebBrowser();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblDeleoper = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.cbxUserActivated = new System.Windows.Forms.CheckBox();
            this.lblUserActive = new System.Windows.Forms.Label();
            this.lblUserCalcAge = new System.Windows.Forms.Label();
            this.mCal = new System.Windows.Forms.MonthCalendar();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserChange = new System.Windows.Forms.Button();
            this.tbxUserPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lblUserAge = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.lbxEmpty = new System.Windows.Forms.ListBox();
            this.rbtnEmpty = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlGames.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxGames
            // 
            this.lbxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxGames.FormattingEnabled = true;
            this.lbxGames.ItemHeight = 20;
            this.lbxGames.Location = new System.Drawing.Point(27, 17);
            this.lbxGames.Name = "lbxGames";
            this.lbxGames.Size = new System.Drawing.Size(238, 744);
            this.lbxGames.TabIndex = 1;
            this.lbxGames.Visible = false;
            this.lbxGames.SelectedIndexChanged += new System.EventHandler(this.lbxGames_SelectedIndexChanged);
            // 
            // llblLoadGames
            // 
            this.llblLoadGames.AutoSize = true;
            this.llblLoadGames.Location = new System.Drawing.Point(18, 632);
            this.llblLoadGames.Name = "llblLoadGames";
            this.llblLoadGames.Size = new System.Drawing.Size(162, 13);
            this.llblLoadGames.TabIndex = 2;
            this.llblLoadGames.TabStop = true;
            this.llblLoadGames.Text = "Load ALl Games from Computer :";
            this.llblLoadGames.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLoadGames_LinkClicked);
            // 
            // pbrImports
            // 
            this.pbrImports.Location = new System.Drawing.Point(182, 622);
            this.pbrImports.Maximum = 10000;
            this.pbrImports.Name = "pbrImports";
            this.pbrImports.Size = new System.Drawing.Size(230, 23);
            this.pbrImports.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rbtnEditUser
            // 
            this.rbtnEditUser.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEditUser.AutoSize = true;
            this.rbtnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEditUser.Location = new System.Drawing.Point(365, 17);
            this.rbtnEditUser.Name = "rbtnEditUser";
            this.rbtnEditUser.Size = new System.Drawing.Size(121, 35);
            this.rbtnEditUser.TabIndex = 20;
            this.rbtnEditUser.TabStop = true;
            this.rbtnEditUser.Text = "Edit Users";
            this.rbtnEditUser.UseVisualStyleBackColor = true;
            this.rbtnEditUser.CheckedChanged += new System.EventHandler(this.rbtnEditUser_CheckedChanged);
            // 
            // rbtnEditGames
            // 
            this.rbtnEditGames.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEditGames.AutoSize = true;
            this.rbtnEditGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEditGames.Location = new System.Drawing.Point(504, 17);
            this.rbtnEditGames.Name = "rbtnEditGames";
            this.rbtnEditGames.Size = new System.Drawing.Size(133, 35);
            this.rbtnEditGames.TabIndex = 21;
            this.rbtnEditGames.TabStop = true;
            this.rbtnEditGames.Text = "Edit Games";
            this.rbtnEditGames.UseVisualStyleBackColor = true;
            this.rbtnEditGames.CheckedChanged += new System.EventHandler(this.rbtnEditGames_CheckedChanged);
            // 
            // pnlGames
            // 
            this.pnlGames.Controls.Add(this.btnSearchForPossDescription);
            this.pnlGames.Controls.Add(this.tbxReview);
            this.pnlGames.Controls.Add(this.lblReview);
            this.pnlGames.Controls.Add(this.cmbxAge);
            this.pnlGames.Controls.Add(this.lblGamesCountDown);
            this.pnlGames.Controls.Add(this.btnGameDelete);
            this.pnlGames.Controls.Add(this.btnGameAdd);
            this.pnlGames.Controls.Add(this.btnSaveGame);
            this.pnlGames.Controls.Add(this.btnChangeGame);
            this.pnlGames.Controls.Add(this.btnPathChange);
            this.pnlGames.Controls.Add(this.tbxPath);
            this.pnlGames.Controls.Add(this.pbrImports);
            this.pnlGames.Controls.Add(this.tbxReleaseDate);
            this.pnlGames.Controls.Add(this.llblLoadGames);
            this.pnlGames.Controls.Add(this.tbxDeveloper);
            this.pnlGames.Controls.Add(this.tbxName);
            this.pnlGames.Controls.Add(this.btnNewGame);
            this.pnlGames.Controls.Add(this.wbrsDescription);
            this.pnlGames.Controls.Add(this.lblDescribe);
            this.pnlGames.Controls.Add(this.lblPath);
            this.pnlGames.Controls.Add(this.lblAge);
            this.pnlGames.Controls.Add(this.lblRelease);
            this.pnlGames.Controls.Add(this.lblDeleoper);
            this.pnlGames.Controls.Add(this.lblName);
            this.pnlGames.Location = new System.Drawing.Point(279, 63);
            this.pnlGames.Name = "pnlGames";
            this.pnlGames.Size = new System.Drawing.Size(502, 708);
            this.pnlGames.TabIndex = 22;
            this.pnlGames.Visible = false;
            // 
            // btnSearchForPossDescription
            // 
            this.btnSearchForPossDescription.Enabled = false;
            this.btnSearchForPossDescription.Location = new System.Drawing.Point(272, 238);
            this.btnSearchForPossDescription.Name = "btnSearchForPossDescription";
            this.btnSearchForPossDescription.Size = new System.Drawing.Size(193, 22);
            this.btnSearchForPossDescription.TabIndex = 53;
            this.btnSearchForPossDescription.Text = "Search Description in web";
            this.btnSearchForPossDescription.UseVisualStyleBackColor = true;
            this.btnSearchForPossDescription.Click += new System.EventHandler(this.btnSearchForPossDescription_Click);
            // 
            // tbxReview
            // 
            this.tbxReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReview.Location = new System.Drawing.Point(173, 188);
            this.tbxReview.Name = "tbxReview";
            this.tbxReview.ReadOnly = true;
            this.tbxReview.Size = new System.Drawing.Size(292, 22);
            this.tbxReview.TabIndex = 46;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(11, 198);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(59, 16);
            this.lblReview.TabIndex = 45;
            this.lblReview.Text = "Review :";
            // 
            // cmbxAge
            // 
            this.cmbxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAge.FormattingEnabled = true;
            this.cmbxAge.Items.AddRange(new object[] {
            "0",
            "6",
            "12",
            "16",
            "18"});
            this.cmbxAge.Location = new System.Drawing.Point(173, 114);
            this.cmbxAge.Name = "cmbxAge";
            this.cmbxAge.Size = new System.Drawing.Size(292, 23);
            this.cmbxAge.TabIndex = 40;
            // 
            // lblGamesCountDown
            // 
            this.lblGamesCountDown.AutoSize = true;
            this.lblGamesCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesCountDown.Location = new System.Drawing.Point(418, 621);
            this.lblGamesCountDown.Name = "lblGamesCountDown";
            this.lblGamesCountDown.Size = new System.Drawing.Size(35, 24);
            this.lblGamesCountDown.TabIndex = 39;
            this.lblGamesCountDown.Text = "0/0";
            // 
            // btnGameDelete
            // 
            this.btnGameDelete.Enabled = false;
            this.btnGameDelete.Location = new System.Drawing.Point(216, 651);
            this.btnGameDelete.Name = "btnGameDelete";
            this.btnGameDelete.Size = new System.Drawing.Size(73, 35);
            this.btnGameDelete.TabIndex = 38;
            this.btnGameDelete.Text = "Delete";
            this.btnGameDelete.UseVisualStyleBackColor = true;
            this.btnGameDelete.Click += new System.EventHandler(this.btnGameDelete_Click);
            // 
            // btnGameAdd
            // 
            this.btnGameAdd.Enabled = false;
            this.btnGameAdd.Location = new System.Drawing.Point(122, 651);
            this.btnGameAdd.Name = "btnGameAdd";
            this.btnGameAdd.Size = new System.Drawing.Size(84, 35);
            this.btnGameAdd.TabIndex = 37;
            this.btnGameAdd.Text = "Add Game";
            this.btnGameAdd.UseVisualStyleBackColor = true;
            this.btnGameAdd.Click += new System.EventHandler(this.btnGameAdd_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Enabled = false;
            this.btnSaveGame.Location = new System.Drawing.Point(393, 651);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(72, 35);
            this.btnSaveGame.TabIndex = 36;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnChangeGame
            // 
            this.btnChangeGame.Enabled = false;
            this.btnChangeGame.Location = new System.Drawing.Point(298, 651);
            this.btnChangeGame.Name = "btnChangeGame";
            this.btnChangeGame.Size = new System.Drawing.Size(89, 35);
            this.btnChangeGame.TabIndex = 35;
            this.btnChangeGame.Text = "Change Game";
            this.btnChangeGame.UseVisualStyleBackColor = true;
            this.btnChangeGame.Click += new System.EventHandler(this.btnChangeGame_Click);
            // 
            // btnPathChange
            // 
            this.btnPathChange.Enabled = false;
            this.btnPathChange.Location = new System.Drawing.Point(422, 150);
            this.btnPathChange.Name = "btnPathChange";
            this.btnPathChange.Size = new System.Drawing.Size(43, 22);
            this.btnPathChange.TabIndex = 34;
            this.btnPathChange.Text = "New";
            this.btnPathChange.UseVisualStyleBackColor = true;
            this.btnPathChange.Click += new System.EventHandler(this.btnPathChange_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPath.Location = new System.Drawing.Point(173, 150);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = true;
            this.tbxPath.Size = new System.Drawing.Size(243, 22);
            this.tbxPath.TabIndex = 28;
            // 
            // tbxReleaseDate
            // 
            this.tbxReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReleaseDate.Location = new System.Drawing.Point(173, 79);
            this.tbxReleaseDate.Name = "tbxReleaseDate";
            this.tbxReleaseDate.ReadOnly = true;
            this.tbxReleaseDate.Size = new System.Drawing.Size(292, 22);
            this.tbxReleaseDate.TabIndex = 31;
            this.tbxReleaseDate.TextChanged += new System.EventHandler(this.tbxReleaseDate_TextChanged);
            // 
            // tbxDeveloper
            // 
            this.tbxDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDeveloper.Location = new System.Drawing.Point(173, 47);
            this.tbxDeveloper.Name = "tbxDeveloper";
            this.tbxDeveloper.ReadOnly = true;
            this.tbxDeveloper.Size = new System.Drawing.Size(292, 22);
            this.tbxDeveloper.TabIndex = 30;
            this.tbxDeveloper.TextChanged += new System.EventHandler(this.tbxDeveloper_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(173, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(292, 22);
            this.tbxName.TabIndex = 29;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(22, 651);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 35);
            this.btnNewGame.TabIndex = 21;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // wbrsDescription
            // 
            this.wbrsDescription.Location = new System.Drawing.Point(22, 291);
            this.wbrsDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrsDescription.Name = "wbrsDescription";
            this.wbrsDescription.Size = new System.Drawing.Size(443, 325);
            this.wbrsDescription.TabIndex = 28;
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(18, 241);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(82, 16);
            this.lblDescribe.TabIndex = 27;
            this.lblDescribe.Text = "Description :";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(20, 156);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 16);
            this.lblPath.TabIndex = 26;
            this.lblPath.Text = "Path :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(19, 117);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 16);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age : ";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelease.Location = new System.Drawing.Point(19, 85);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(98, 16);
            this.lblRelease.TabIndex = 24;
            this.lblRelease.Text = "Release Date :";
            // 
            // lblDeleoper
            // 
            this.lblDeleoper.AutoSize = true;
            this.lblDeleoper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleoper.Location = new System.Drawing.Point(19, 53);
            this.lblDeleoper.Name = "lblDeleoper";
            this.lblDeleoper.Size = new System.Drawing.Size(78, 16);
            this.lblDeleoper.TabIndex = 23;
            this.lblDeleoper.Text = "Developer :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name :";
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.cbxUserActivated);
            this.pnlUsers.Controls.Add(this.lblUserActive);
            this.pnlUsers.Controls.Add(this.lblUserCalcAge);
            this.pnlUsers.Controls.Add(this.mCal);
            this.pnlUsers.Controls.Add(this.btnUserDelete);
            this.pnlUsers.Controls.Add(this.btnUserAdd);
            this.pnlUsers.Controls.Add(this.btnUserSave);
            this.pnlUsers.Controls.Add(this.btnUserChange);
            this.pnlUsers.Controls.Add(this.tbxUserPassword);
            this.pnlUsers.Controls.Add(this.tbxUserName);
            this.pnlUsers.Controls.Add(this.btnNewUser);
            this.pnlUsers.Controls.Add(this.lblUserAge);
            this.pnlUsers.Controls.Add(this.lblUserPassword);
            this.pnlUsers.Controls.Add(this.lblUserName);
            this.pnlUsers.Location = new System.Drawing.Point(279, 63);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(502, 708);
            this.pnlUsers.TabIndex = 37;
            this.pnlUsers.Visible = false;
            // 
            // cbxUserActivated
            // 
            this.cbxUserActivated.AutoSize = true;
            this.cbxUserActivated.Checked = true;
            this.cbxUserActivated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUserActivated.Enabled = false;
            this.cbxUserActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserActivated.Location = new System.Drawing.Point(167, 274);
            this.cbxUserActivated.Name = "cbxUserActivated";
            this.cbxUserActivated.Size = new System.Drawing.Size(15, 14);
            this.cbxUserActivated.TabIndex = 42;
            this.cbxUserActivated.UseVisualStyleBackColor = true;
            // 
            // lblUserActive
            // 
            this.lblUserActive.AutoSize = true;
            this.lblUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserActive.Location = new System.Drawing.Point(20, 272);
            this.lblUserActive.Name = "lblUserActive";
            this.lblUserActive.Size = new System.Drawing.Size(102, 16);
            this.lblUserActive.TabIndex = 41;
            this.lblUserActive.Text = "User Activated :";
            // 
            // lblUserCalcAge
            // 
            this.lblUserCalcAge.AutoSize = true;
            this.lblUserCalcAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCalcAge.Location = new System.Drawing.Point(167, 85);
            this.lblUserCalcAge.Name = "lblUserCalcAge";
            this.lblUserCalcAge.Size = new System.Drawing.Size(15, 16);
            this.lblUserCalcAge.TabIndex = 40;
            this.lblUserCalcAge.Text = "0";
            // 
            // mCal
            // 
            this.mCal.Enabled = false;
            this.mCal.Location = new System.Drawing.Point(239, 85);
            this.mCal.MaxDate = new System.DateTime(2020, 12, 6, 0, 0, 0, 0);
            this.mCal.Name = "mCal";
            this.mCal.TabIndex = 39;
            this.mCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCal_DateChanged);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Enabled = false;
            this.btnUserDelete.Location = new System.Drawing.Point(212, 649);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(77, 35);
            this.btnUserDelete.TabIndex = 38;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Enabled = false;
            this.btnUserAdd.Location = new System.Drawing.Point(123, 648);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(83, 35);
            this.btnUserAdd.TabIndex = 37;
            this.btnUserAdd.Text = "Add User";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.Enabled = false;
            this.btnUserSave.Location = new System.Drawing.Point(393, 649);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(72, 35);
            this.btnUserSave.TabIndex = 36;
            this.btnUserSave.Text = "Save User";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserChange
            // 
            this.btnUserChange.Enabled = false;
            this.btnUserChange.Location = new System.Drawing.Point(295, 649);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Size = new System.Drawing.Size(92, 35);
            this.btnUserChange.TabIndex = 35;
            this.btnUserChange.Text = "Change User";
            this.btnUserChange.UseVisualStyleBackColor = true;
            this.btnUserChange.Click += new System.EventHandler(this.btnUserChange_Click);
            // 
            // tbxUserPassword
            // 
            this.tbxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserPassword.Location = new System.Drawing.Point(173, 47);
            this.tbxUserPassword.Name = "tbxUserPassword";
            this.tbxUserPassword.ReadOnly = true;
            this.tbxUserPassword.Size = new System.Drawing.Size(292, 22);
            this.tbxUserPassword.TabIndex = 30;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(173, 12);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.ReadOnly = true;
            this.tbxUserName.Size = new System.Drawing.Size(292, 22);
            this.tbxUserName.TabIndex = 29;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(23, 649);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(94, 35);
            this.btnNewUser.TabIndex = 21;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // lblUserAge
            // 
            this.lblUserAge.AutoSize = true;
            this.lblUserAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAge.Location = new System.Drawing.Point(19, 85);
            this.lblUserAge.Name = "lblUserAge";
            this.lblUserAge.Size = new System.Drawing.Size(39, 16);
            this.lblUserAge.TabIndex = 24;
            this.lblUserAge.Text = "Age :";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(19, 53);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(74, 16);
            this.lblUserPassword.TabIndex = 23;
            this.lblUserPassword.Text = "Password :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(19, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 16);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "Name :";
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.Controls.Add(this.lblSelect);
            this.pnlEmpty.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlEmpty.Location = new System.Drawing.Point(279, 63);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(502, 708);
            this.pnlEmpty.TabIndex = 38;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(167, 365);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(157, 31);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Task";
            // 
            // lbxUsers
            // 
            this.lbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 20;
            this.lbxUsers.Location = new System.Drawing.Point(27, 17);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(238, 744);
            this.lbxUsers.TabIndex = 39;
            this.lbxUsers.Visible = false;
            this.lbxUsers.SelectedIndexChanged += new System.EventHandler(this.lbxUsers_SelectedIndexChanged);
            // 
            // lbxEmpty
            // 
            this.lbxEmpty.Enabled = false;
            this.lbxEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmpty.FormattingEnabled = true;
            this.lbxEmpty.ItemHeight = 20;
            this.lbxEmpty.Location = new System.Drawing.Point(27, 17);
            this.lbxEmpty.Name = "lbxEmpty";
            this.lbxEmpty.Size = new System.Drawing.Size(238, 744);
            this.lbxEmpty.TabIndex = 40;
            this.lbxEmpty.Visible = false;
            // 
            // rbtnEmpty
            // 
            this.rbtnEmpty.AutoSize = true;
            this.rbtnEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEmpty.Location = new System.Drawing.Point(291, 28);
            this.rbtnEmpty.Name = "rbtnEmpty";
            this.rbtnEmpty.Size = new System.Drawing.Size(14, 13);
            this.rbtnEmpty.TabIndex = 41;
            this.rbtnEmpty.TabStop = true;
            this.rbtnEmpty.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 796);
            this.Controls.Add(this.rbtnEmpty);
            this.Controls.Add(this.lbxEmpty);
            this.Controls.Add(this.pnlGames);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlEmpty);
            this.Controls.Add(this.rbtnEditGames);
            this.Controls.Add(this.rbtnEditUser);
            this.Controls.Add(this.lbxUsers);
            this.Controls.Add(this.lbxGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlGames.ResumeLayout(false);
            this.pnlGames.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            this.pnlEmpty.ResumeLayout(false);
            this.pnlEmpty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxGames;
        private System.Windows.Forms.LinkLabel llblLoadGames;
        private System.Windows.Forms.ProgressBar pbrImports;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton rbtnEditUser;
        private System.Windows.Forms.Panel pnlGames;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnChangeGame;
        private System.Windows.Forms.Button btnPathChange;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.TextBox tbxReleaseDate;
        private System.Windows.Forms.TextBox tbxDeveloper;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.WebBrowser wbrsDescription;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblDeleoper;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtnEditGames;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserChange;
        private System.Windows.Forms.TextBox tbxUserPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label lblUserAge;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlEmpty;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.ListBox lbxEmpty;
        private System.Windows.Forms.RadioButton rbtnEmpty;
        private System.Windows.Forms.Button btnGameAdd;
        private System.Windows.Forms.Button btnGameDelete;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Label lblGamesCountDown;
        private System.Windows.Forms.ComboBox cmbxAge;
        private System.Windows.Forms.TextBox tbxReview;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.MonthCalendar mCal;
        private System.Windows.Forms.Label lblUserCalcAge;
        private System.Windows.Forms.CheckBox cbxUserActivated;
        private System.Windows.Forms.Label lblUserActive;
        private System.Windows.Forms.Button btnSearchForPossDescription;
    }
}