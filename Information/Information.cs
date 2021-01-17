using System;
using System.Diagnostics;
using System.Windows.Forms;
using GameLauncher.Handler;

namespace GameLauncher.Information
{
    public class Information
    {
        private readonly Random _rnd = new Random();

        #region Pin Set / Get

        /// <summary>
        /// Reads the Admin pin
        /// </summary>
        /// <returns>
        /// string with the pin.ToString()
        /// </returns>
        public string ReadPin()
        {
            // Read
            string pin = "no";

            if (FileHandler.IsPinFile())
            {
                pin = FileHandler.GetAdminPin();
            }
            else
            {
                MessageBox.Show("File with pin is not created yet!", "Error");
            }


            return pin;
        }

        /// <summary>
        /// Creates a random pin if game is launched the first time
        /// </summary>
        public void WritePin()
        {
            // Writes pin
            // In last Index is the pin
            int pin = _rnd.Next(1000, 9999);

            FileHandler.WriteToPinFile(pin.ToString());
            Debug.Print(pin.ToString());

            string news = $"You are the first user, so here is the admin pin: {pin}";
            MessageBox.Show(news, "Admin Pin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion


        // These is the collection of all strings / paths needed for this Projekt

        public string PathFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.GameLauncher";

        public string PathGameMedia = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.GameLauncher\\Media\\";
        public string PathFileUsers = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.GameLauncher\\user.csv";
        public string PathFileGames = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.GameLauncher\\games.csv";
        public string PathPin = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.GameLauncher\\pin.csv";
        public string PathFailDes = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.GameLauncher\\FailDes.txt";
        

        public string PathSteamLibrary = @"G:\SteamLibrary\steamapps\common";

    }

    public static class User
    {
        public static string Name { get; set; }
        public static string  Password { get; set; }
        public static string Age { get; set; }
    }
}
