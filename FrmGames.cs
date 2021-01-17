using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GameLauncher.Handler;
using GameLauncher.Objects;

namespace GameLauncher
{
    public partial class FrmGames : Form
    {
        public FrmGames()
        {
            InitializeComponent();
        }

        private List<Game> _games;

        /// <summary>
        /// Gets the game age.
        /// </summary>
        /// <param name="gameAge"></param>
        /// <returns>
        /// an Image with the USK of the game age
        /// </returns>
        private Image GetImage(string gameAge)
        {
            // Returns a image depending on the age given
            switch (gameAge)
            {
                case "404":
                    return Properties.Resources._404_space_invaders;
                case "0":
                    return Properties.Resources.USK0;
                case "6":
                    return Properties.Resources.USK6;
                case "12":
                    return Properties.Resources.USK12;
                case "16":
                    return Properties.Resources.USK16;
                default:
                    return Properties.Resources.USK18;
            }
        }

        /// <summary>
        /// Clear and adds all games of the lbxAllGames
        /// </summary>
        private void UpdateList()
        {
            lbxAllGames.Items.Clear();
            foreach (Game game in _games)
            {
                lbxAllGames.Items.Add(game.Name);
            }
        }

        private void FrmGames_Shown(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();
        }
        private void lbxAllGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxAllGames.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            tabcGG.SelectedIndex = 0;
            Game game = _games[index];

            // Writes all the game information into form
            lblGGName.Text = game.Name;
            lblTGName.Text = game.Name;
            lblGGDeveloper.Text = game.Developer;
            lblGGLastPlayed.Text = game.LastPlayed;
            lblGGRealseDate.Text = game.ReleaseDate;
            pbxGGAge.BackgroundImage = GetImage(game.Age);
            wbrGGDesription.DocumentText = game.Desccription;
            lblGGReviewSummery.Text = game.Review;

            // sets the right image depending on the bool Favorite
            btnFav.BackgroundImage = game.Favorite ? Properties.Resources.thumbsUpFull : Properties.Resources.thumbsUpEmpty;

            // Trys to set the Image of the game path icons
            try
            {
                pbxGGIcon.BackgroundImage = Icon.ExtractAssociatedIcon(game.Path)?.ToBitmap();
            }
            catch (Exception)
            {
                // ignored
            }

            // If game has no videos saved, do nothing
            if (game.Videos.Count != 0 || game.Videos[0] != "noVideos")
            {
                string videoPath = game.Videos[0];

                windowsMediaPlayer.URL = videoPath;
            }

             
            int gameAge = 18;
            int userAge = 0;
            try
            {
                gameAge = Convert.ToInt32(game.Age);
                userAge = Convert.ToInt32(Information.User.Age);
            }
            catch (Exception)
            {
                // ignored
            }

            // makes the Button enable depending on the age of the user and game
            btnPlay.Enabled = userAge >= gameAge;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Starts the selected game
            int index = lbxAllGames.SelectedIndex;
            if (index != -1)
            {
                Game game = _games[index];
                Process.Start(game.Path);
            }
        }
        private void btnFav_Click(object sender, EventArgs e)
        {
            // Changes the bool 
            int index = lbxAllGames.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            Game game = _games[index];
            if (!game.Favorite)
            {
                btnFav.BackgroundImage = Properties.Resources.thumbsUpFull;
                game.Favorite = true;
            }
            else
            {
                btnFav.BackgroundImage = Properties.Resources.thumbsUpEmpty;
                game.Favorite = false;
            }
        }
        private void FrmGames_Activated(object sender, EventArgs e)
        {
            // When the Form is activated it will Update the Gamelist and the User informations
            _games = FileHandler.GetGamesList();
            UpdateList(); 

            try
            {
                lblUUName.Text = Information.User.Name;
                lblUUAge.Text = Information.User.Age;
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Opens the a new window
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowInTaskbar = false;
            frmlogin.ShowDialog();
            
        }
        private void tabcGG_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is the TabControl on the bottum of the game view
            //
            // Depending on what the user clicked it will either show the Infos, Game Description, or the images
            // by default the description

            int index = tabcGG.SelectedIndex;
            int indexGame = lbxAllGames.SelectedIndex;
            if (index == -1 || indexGame == -1)
            {
                return;
            }

            Game game = _games[indexGame];

            if (index == 2 && game.Images[0] != "noImg") 
            {
                // it will calc the amount of images given and place them 
                // max 12 images

                tabPictures.Controls.Clear();
                int amoung = game.Images.Count; // Get all games

                if (amoung >= 8)
                {
                    amoung = 8;
                }

                int x = 10;
                int y = 10;

                for (int i = 1; i < amoung + 1; i++)
                {
                    PictureBox pbx = new PictureBox
                    {
                        Location = new Point(x, y),
                        Width = 160,
                        Height = 95,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        //BorderStyle = BorderStyle.FixedSingle,
                    };

                    pbx.BackgroundImage = new Bitmap(game.Images[i - 1]);

                    x += 165;

                    tabPictures.Controls.Add(pbx);
                    if (i % 4 == 0)
                    {
                        y += 110;
                        x = 10;
                    }
                }   

            }
        }
        private void FrmGames_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Updates game file 

            // Only for the favorites
            FileHandler.WriteToGamesFile(_games);
        }
    }
}
