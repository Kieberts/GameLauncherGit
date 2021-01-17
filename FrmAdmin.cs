using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using GameLauncher.Handler;
using GameLauncher.Objects;

namespace GameLauncher
{
    public partial class FrmAdmin : Form
    {
        private readonly ScrapeHandler _scrapeHandler = new ScrapeHandler();
        private readonly Information.Information _infos = new Information.Information();
        
        // Lists to  edit games / users
        List<Game> _games;
        List<Person> _users = new List<Person>();

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            mCal.MaxDate = DateTime.Today;

            rbtnEditGames.Checked = false;
            rbtnEditUser.Checked = false;
            rbtnEmpty.Checked = true;
            rbtnEmpty.Visible = false;

            pnlEmpty.Visible = true;
            pnlUsers.Visible = false;
            pnlGames.Visible = false;

            lbxUsers.Visible = false;
            lbxGames.Visible = false;
            lbxEmpty.Visible = true;


            // Reads from File and add to list (Updates the lists)
            try
            {
                _games = FileHandler.GetGamesList();
                
                Debug.Print("All read");
            }
            catch (Exception)
            {
                Debug.Print("Could NOT read from File");
            }

            try
            {
                _users = FileHandler.GetUserList();
            }
            catch (Exception)
            {
                Debug.Print("Could NOT read from File");
            }
        }

        /// <summary>
        /// Gets a control like a panel. It will clear all the Textboxes
        /// </summary>
        /// <param name="pnl"></param>
        private void ClearTextBox(Control pnl)
        {
            foreach (object item in pnl.Controls)
            {
                if (item is TextBox box)
                {
                    box.Clear();
                }
            }
        }

        /// <summary>
        /// Gets a control like a panel and a type of control. It will set the visibility to false except one control
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <param name="controlShow"></param>
        private void WhatVisible(Control control, Type type, Control controlShow)
        {
            foreach (Control item in control.Controls)
            {
                if (item.GetType() == type)
                {
                    item.Visible = false;
                }
            }

            controlShow.Visible = true;
        }

        /// <summary>
        /// Gets a control like a panel and bool statement. It will set all Textboxes to ReadOnly = bool statement
        /// </summary>
        /// <param name="control"></param>
        /// <param name="b"></param>
        private void WhatReadOnly(Control control, bool b)
        {
            foreach (TextBox item in control.Controls.OfType<TextBox>())
            {
                item.ReadOnly = b;
            }
        }

        /// <summary>
        /// Clears and adds items to Userslist
        /// </summary>
        private void UpdateUserList()
        {
            lbxUsers.Items.Clear();
            foreach (Person person in _users)
            {
                lbxUsers.Items.Add(person.Name);
            }
        }

        /// <summary>
        /// Clears and adds items to Gamelist
        /// </summary>
        private void UpdateGameList()
        {
            lbxGames.Items.Clear();
            foreach (Game game in _games)
            {
                lbxGames.Items.Add(game.Name);
            }
        }

        /// <summary>
        /// Checks if user entered somthing into the Textboxes of a given Control
        /// </summary>
        /// <param name="control"></param>
        /// <returns>
        /// a bool statement depending of it was ok or not
        /// </returns>
        private bool CheckImput(Control control)
        {
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                if (textBox.Text == null || textBox.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Gets the selected DateTime. It will calculate the age
        /// </summary>
        /// <param name="selectedDate"></param>
        /// <returns>
        /// the selected age
        /// </returns>
        private string CalcAge(DateTime selectedDate)
        {
            DateTime date = DateTime.Today;
            int age = date.Year - selectedDate.Year;

            if (date.Month < selectedDate.Month)
            {
                age--;
            }

            return age.ToString();
        }


        private void rbtnEditGames_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBox(pnlGames);
            wbrsDescription.DocumentText = "";

            UpdateGameList();

            pnlGames.Visible = true;
            pnlUsers.Visible = false;
            pnlEmpty.Visible = false;

            lbxGames.Visible = true;
            lbxUsers.Visible = false;
            lbxEmpty.Visible = false;

            btnNewUser.Enabled = true;
            btnUserAdd.Enabled = false;
            btnUserChange.Enabled = false;
            btnUserSave.Enabled = false;
            btnUserDelete.Enabled = false;

            tbxName.ReadOnly = true;
            tbxDeveloper.ReadOnly = true;
            tbxReleaseDate.ReadOnly = true;
            tbxPath.ReadOnly = true;

            lbxGames.Enabled = true;
            errorProvider.Clear();
        }
        private void llblLoadGames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "This feature needs a few changes in the code. \nIf you wanna use it, you will need to go the FrmAdmin and press this LinkLabel\nRemove the 'return' and change the 'PathSteamLibrary' string to your folder with the STEAM games\nreturning.... ");
            return;


            //llblLoadGames.Enabled = false;
            //_scraperHandler.Entries = games;

            string steamLibrary = _infos.PathSteamLibrary;
            var gameAllPaths = FileHandler.GetDirectoriesSteamGameNames(steamLibrary); // these are only the stream one but we can add the other to this string and it should work the same

            int numberOfAllGames = gameAllPaths.Length;
            lblGamesCountDown.Text = "0 / " + numberOfAllGames;
            // sets the right Values to Progressbar
            pbrImports.Maximum = gameAllPaths.Length;
            pbrImports.Value = 0;

            // Get inforamtion to all these Game 
            foreach (string steamGame in gameAllPaths)
            {
                // Get Game instance with almost all properties besides "Path"!
                Game game = _scrapeHandler.ScrapeData(steamGame.Substring(33));

                // Gets all exe files from this folder and add the first one to Game instance
                var exesWithExe = FileHandler.GetExeWith(steamGame);  

                // FInd the biggest exe
                game.Path = FileHandler.GetBiggestFile(exesWithExe); 

                // Check the whole list if game name already exits
                // bool isIN = _games.Any(gameInList => gameInList.Name == game.Name);
                bool isIn = false;
                foreach (Game gameInList in _games)
                {
                    if (gameInList.Name != game.Name) continue;

                    isIn = true;
                    break;
                }

                // If game.Name doesnt exists => add game
                if (!isIn)
                {
                    _games.Add(game);
                }


                pbrImports.Value += 1;
            }

            pbrImports.Value = 0;
            lblGamesCountDown.Text = numberOfAllGames.ToString() + " /" + numberOfAllGames.ToString();
            UpdateGameList();
        }
        private void lbxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChangeGame.Enabled = true;
            btnSaveGame.Enabled = true;
            btnGameDelete.Enabled = true;

            int index = lbxGames.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            // Writes into textBoxes
            Game game = _games[index];

            // After index was change, write all the properties of the game into the form
            tbxName.Text = game.Name;
            tbxDeveloper.Text = game.Developer;
            tbxReleaseDate.Text = game.ReleaseDate;
            cmbxAge.Text = game.Age;
            tbxPath.Text = game.Path;
            wbrsDescription.DocumentText = game.Desccription;


            tbxReview.Text = game.Review;
        }
        #region tbx Games TextChanges

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (tbxName.Text == "")
            {
                errorProvider.SetError(tbxName, "Cannot be empty!");
                lbxGames.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tbxDeveloper_TextChanged(object sender, EventArgs e)
        {
            if (tbxDeveloper.Text == "")
            {
                errorProvider.SetError(tbxDeveloper, "Cannot be empty!");
                lbxGames.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tbxReleaseDate_TextChanged(object sender, EventArgs e)
        {
            if (tbxReleaseDate.Text == "")
            {
                lbxGames.Enabled = false;
                errorProvider.SetError(tbxReleaseDate, "Cannot be empty!");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        #endregion
        private void btnChangeGame_Click(object sender, EventArgs e)
        {
            lbxGames.Enabled = false;
            btnNewGame.Enabled = false;
            btnChangeGame.Enabled = false;
            btnGameDelete.Enabled = false;
            llblLoadGames.Enabled = false;

            rbtnEditUser.Enabled = false;

            btnPathChange.Enabled = true;
            btnSearchForPossDescription.Enabled = true;

            WhatReadOnly(pnlGames, false);
            tbxPath.ReadOnly = true;

        }
        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            lbxGames.Enabled = true;
            btnNewGame.Enabled = true;
            llblLoadGames.Enabled = true;

            rbtnEditUser.Enabled = true;

            btnPathChange.Enabled = false;
            btnSearchForPossDescription.Enabled = false;

            WhatReadOnly(pnlGames, false);

            int index = lbxGames.SelectedIndex;
            Game game = _games[index];

            // It will update the game with the new strings 

            game.Name = tbxName.Text;
            game.Age = cmbxAge.Text;
            game.Developer = tbxDeveloper.Text;
            game.Path = tbxPath.Text;
            game.ReleaseDate = tbxReleaseDate.Text;
            game.Review = tbxReview.Text;

            _games[index] = game;
            
            UpdateGameList();

            lbxGames.SelectedIndex = _games.IndexOf(game);
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            tbxName.Focus();
            ClearTextBox(pnlGames);
            errorProvider.Clear();
            cmbxAge.SelectedIndex = -1;


            lbxGames.Enabled = false;

            btnChangeGame.Enabled = false;
            btnSaveGame.Enabled = false;
            btnNewGame.Enabled = false;
            btnGameDelete.Enabled = false;

            rbtnEditUser.Enabled = false;

            llblLoadGames.Enabled = false;


            btnGameAdd.Enabled = true;
            btnPathChange.Enabled = true;
            btnSearchForPossDescription.Enabled = true;
            wbrsDescription.DocumentText = String.Empty;

            WhatReadOnly(pnlGames, false);
            tbxPath.ReadOnly = true;
        }
        private void btnGameAdd_Click(object sender, EventArgs e)
        {
            // Checks if the imput of game is ok
            if (!CheckImput(pnlGames) || cmbxAge.SelectedIndex == -1)
            {
                DialogResult gameResult = MessageBox.Show("Check imput! Or Game wont be saved", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                switch (gameResult)
                {
                    case DialogResult.OK:
                        lbxGames.Enabled = true;
                        btnNewGame.Enabled = true;
                        btnChangeGame.Enabled = true;
                        btnGameDelete.Enabled = true;
                        llblLoadGames.Enabled = true;

                        rbtnEditUser.Enabled = true;

                        btnSaveGame.Enabled = false;
                        btnGameAdd.Enabled = false;
                        btnPathChange.Enabled = false;
                        btnSearchForPossDescription.Enabled = false;

                        WhatReadOnly(pnlGames, true);

                        ClearTextBox(pnlGames);
                        wbrsDescription.DocumentText = String.Empty;
                        cmbxAge.SelectedIndex = -1;
                        return;

                    default:
                        return;
                }
            }

            lbxGames.Enabled = true;
            btnNewGame.Enabled = true;
            btnChangeGame.Enabled = true;
            btnGameDelete.Enabled = true;
            llblLoadGames.Enabled = true;

            rbtnEditUser.Enabled = true;

            btnSaveGame.Enabled = false;
            btnGameAdd.Enabled = false;
            btnPathChange.Enabled = false;
            btnSearchForPossDescription.Enabled = false;

            WhatReadOnly(pnlGames, true);

            List<string> image = new List<string>();
            List<string> video = new List<string>();

            image.Add("noImage");
            video.Add("noVideo");

            // Create a new game with all its properties the user entered
            Game game = new Game
            {
                Name = tbxName.Text,
                Age = cmbxAge.Text,
                Developer = tbxDeveloper.Text,
                DesccriptionPath = _infos.PathFolder + "\\FailDes.txt",
                Path = tbxPath.Text,
                ReleaseDate = tbxReleaseDate.Text,
                Favorite = false,
                LastPlayed = "never",
                Review = tbxReview.Text,
                Videos = video,
                Images = image,
            };

            _games.Add(game);

            UpdateGameList();

            lbxGames.SelectedIndex = _games.IndexOf(game);


        }
        private void rbtnEditUser_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBox(pnlUsers);
            
            UpdateUserList();

            // Shows Users Panel
            WhatVisible(this, typeof(Panel), pnlUsers);

            // Shows Users ListView
            WhatVisible(this, typeof(ListBox), lbxUsers);


            btnGameAdd.Enabled = false;
            btnChangeGame.Enabled = false;
            btnSaveGame.Enabled = false;

            btnNewGame.Enabled = true;
            btnGameDelete.Enabled = false;

            //tbxUserName.ReadOnly = true;
            //tbxUserPassword.ReadOnly = true;
            //tbxUserAge.ReadOnly = true;
            WhatReadOnly(pnlUsers, true);

            lbxUsers.Enabled = true;
            errorProvider.Clear();
        }
        private void lbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUserChange.Enabled = true;
            btnUserSave.Enabled = true;

            int index = lbxUsers.SelectedIndex;
            // Checks selectedIndex
            if (index == -1) return;

            Person person = _users[index];

            // After index was change, write all the properties of the user into the form
            tbxUserName.Text = person.Name;
            tbxUserPassword.Text = person.Password;
            lblUserCalcAge.Text = person.Age;
            cbxUserActivated.Checked = person.Active;
        }
        private void btnUserChange_Click(object sender, EventArgs e)
        {

            rbtnEditGames.Enabled = false;
            lbxUsers.Enabled = false;

            btnNewUser.Enabled = false;
            btnUserChange.Enabled = false;
            btnUserDelete.Enabled = false;
            

            WhatReadOnly(pnlUsers,false);
            mCal.Enabled = true;
            cbxUserActivated.Enabled = true;
        }
        private void btnUserSave_Click(object sender, EventArgs e)
        {
            // Checks if everythings is inserted
            if (!CheckImput(pnlUsers))
            {
                MessageBox.Show("Enter Username or Password", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblUserCalcAge.Text == "0")
            {
                MessageBox.Show("User can not be 0", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            rbtnEditGames.Enabled = true;
            lbxUsers.Enabled = true;

            btnNewUser.Enabled = true;
            btnUserChange.Enabled = true;

            btnUserDelete.Enabled = true;

            cbxUserActivated.Enabled = false;

            // Makes Textboxes ReadOnly 
            WhatReadOnly(pnlUsers, true);
            mCal.Enabled = false;

            int index = lbxUsers.SelectedIndex;

            // Overrides person in List
            Person person = _users[index];
            person.Name = tbxUserName.Text;
            person.Password = tbxUserPassword.Text;
            person.Age = lblUserCalcAge.Text;
            person.Active = cbxUserActivated.Checked;
            _users[index] = person;

            // Updates List
            UpdateUserList();

            lbxUsers.SelectedIndex = _users.IndexOf(person);
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            rbtnEditGames.Enabled = false;

            // resets the Controls of the User panel
            ClearTextBox(pnlUsers);
            mCal.SetSelectionRange(DateTime.Today, DateTime.Today);
            cbxUserActivated.Checked = true;
            lblUserCalcAge.Text = "0";
            errorProvider.Clear();

            lbxUsers.Enabled = false;

            btnUserChange.Enabled = false;
            btnUserSave.Enabled = false;

            btnUserDelete.Enabled = false;

            btnNewUser.Enabled = false;

            btnUserAdd.Enabled = true;

            WhatReadOnly(pnlUsers, false);
            mCal.Enabled = true;
            cbxUserActivated.Enabled = true;
        }
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            // Checks if everythings is inserted
            if (!CheckImput(pnlUsers) || lblUserCalcAge.Text == "0")
            {
                DialogResult userResult = MessageBox.Show("Check imput! Or User wont be saved! \nAnd you alos have to be older than 1", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                switch (userResult)
                {
                    case DialogResult.OK:

                        rbtnEditGames.Enabled = true;
                        lbxUsers.Enabled = true;

                        btnUserChange.Enabled = true;
                        btnUserSave.Enabled = false;

                        btnNewUser.Enabled = true;
                        btnUserAdd.Enabled = false;

                        WhatReadOnly(pnlUsers, true);
                        mCal.Enabled = false;
                        cbxUserActivated.Enabled = false;

                        ClearTextBox(pnlUsers);
                        mCal.SetSelectionRange(DateTime.Today, DateTime.Today);
                        cbxUserActivated.Checked = true;
                        return;
                    default:
                        return;
                }
            }

            if (!cbxUserActivated.Checked)
            {
                DialogResult isNotAktive = MessageBox.Show("This user wont be aktiv", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                switch (isNotAktive)
                {
                    case DialogResult.Cancel:
                        return;
                }
            }

            rbtnEditGames.Enabled = true;
            lbxUsers.Enabled = true;

            btnUserChange.Enabled = true;
            btnUserSave.Enabled = false;

            btnNewUser.Enabled = true;
            btnUserAdd.Enabled = false;

            WhatReadOnly(pnlUsers, true);
            mCal.Enabled = false;
            cbxUserActivated.Enabled = false;


            Person person = new Person
            {
                Name = tbxUserName.Text,
                Password = tbxUserPassword.Text,
                Age = lblUserCalcAge.Text,
                Active = cbxUserActivated.Checked,
            };

            _users.Add(person);

            UpdateUserList();

            lbxUsers.SelectedIndex = _users.IndexOf(person);
        }
        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Wirte to File 
            try
            {
                FileHandler.WriteToGamesFile(_games);
                FileHandler.WriteToUserFile(_users);
                Debug.Print("Saved");
            }
            catch (Exception)
            {
                Debug.Print("Did NOT Save");
            }
            
        }
        private void btnGameDelete_Click(object sender, EventArgs e)
        {
            int index = lbxGames.SelectedIndex;
            Game game = _games[index];
            _games.Remove(game);
            UpdateGameList();
        }
        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            int index = lbxUsers.SelectedIndex;
            Person person = _users[index];
            _users.Remove(person);
            UpdateUserList();
        }
        private void btnPathChange_Click(object sender, EventArgs e)
        {
            // Open Files  and selects exe file
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                ofd.Filter = "exe files (*.exe)|*.exe";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of file
                    tbxPath.Text = ofd.FileName;
                }
            }
        }
        private void mCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblUserCalcAge.Text = CalcAge(mCal.SelectionStart);
        }
        private void btnSearchForPossDescription_Click(object sender, EventArgs e)
        {
            wbrsDescription.DocumentText = "<p>Could not find anything</p>";
        }
    }
}
