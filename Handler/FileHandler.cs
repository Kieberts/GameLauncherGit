using GameLauncher.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace GameLauncher.Handler
{
    public static class FileHandler
    {
        private static readonly Information.Information Info = new Information.Information();

        private static readonly string PathFolder = Info.PathFolder;
        private static readonly string PathFileUsers = Info.PathFileUsers;
        private static readonly string PathFileGames = Info.PathFileGames;
        public static readonly string PathPin = Info.PathPin;
        public static readonly string PathFailDec = Info.PathFailDes;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// All Get Methods
        
        /// <summary>
        /// Reads all games from the games.csv file
        /// </summary>
        /// <returns>
        /// returns a List of all games
        /// </returns>
        public static List<Game> GetGamesList()
        {
            // Returns all Games
            var games = new List<Game>();

            // Check if Folder / File Exists
            IsFolder();
            IsGames();
            IsFailDes();

            // Reads
            using (StreamReader sr = new StreamReader(PathFileGames))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        // Read user line and splits it 
                        string[] line = sr.ReadLine()?.Split(';');

                        // Creates game with these values and adds to list
                        if (line != null)
                        {
                            games.Add(new Game
                            {
                                Name = line[0],
                                Age = line[1],
                                Path = line[2],
                                Developer = line[3],
                                ReleaseDate = line[4],
                                DesccriptionPath = line[5],
                                LastPlayed = line[6],
                                Review = line[7],
                                Images = SplitImages(line[8]),
                                Videos = SplitVideos(line[9]),
                            });
                        }
                    }
                    catch (NullReferenceException)
                    {
                        Debug.Print("Games must be empty!");
                    }

                }
                sr.Close();
            }

            games = AddDescription(games);

            return games;
        }
        /// <summary>
        /// Reads all users from the users.csv file
        /// </summary>
        /// <returns>
        /// returns a list with all users
        /// </returns>
        public static List<Person> GetUserList()
        {
            // Returns all User
            var users = new List<Person>();

            // Check if Folder / File Exists
            IsFolder();
            IsUser();
            IsFailDes();
            // Reads
            using (StreamReader sr = new StreamReader(PathFileUsers))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        // Read user line and splits it 
                        string[] line = sr.ReadLine()?.Split(';');

                        // Creates user with these values and adds to list
                        if (line != null)
                        {
                            users.Add(new Person
                            {
                                Name = line[0],
                                Password = line[1],
                                Age = line[2],
                                Active = Convert.ToBoolean(line[3])
                            });
                        }

                    }
                    catch (NullReferenceException)
                    {
                        Debug.Print("Users must be empty!");
                    }
                }
                sr.Close();
            }
            return users;
        }
        /// <summary>
        /// Read only aktiv users from users.csv file
        /// </summary>
        /// <returns>
        /// returns List with all aktiv users
        /// </returns>
        public static List<Person> GetActiveUserList()
        {
            // Returns all User
            var users = new List<Person>();

            // Check if Folder / File Exists
            IsFolder();
            IsUser();
            IsFailDes();
            // Reads
            using (StreamReader sr = new StreamReader(PathFileUsers))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        // Read user line and splits it 
                        string[] line = sr.ReadLine()?.Split(';');

                        // Creates user with these values and adds to list
                        if (line != null)
                        {
                            if (Convert.ToBoolean(line[3]))
                            {
                                users.Add(new Person
                                {
                                    Name = line[0],
                                    Password = line[1],
                                    Age = line[2],
                                    Active = Convert.ToBoolean(line[3])
                                });
                            }
                        }

                    }
                    catch (NullReferenceException)
                    {
                        Debug.Print("Users must be empty!");
                    }
                }
                sr.Close();
            }
            return users;
        }
        /// <summary>
        /// Reads the admin pin from pin.csv file
        /// </summary>
        /// <returns>
        /// returns a 4-Digit string
        /// </returns>
        public static string GetAdminPin()
        {
            string pin;

            using (StreamReader sr = new StreamReader(PathPin))
            {
                pin = sr.ReadLine();
                sr.Close();
            }

            return pin;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// All Write to File Methods
        public static void WriteToGamesFile(List<Game> games)
        {
            // Write Games List in File
            using (StreamWriter sw = File.CreateText(PathFileGames))
            {
                foreach (Game game in games)
                {
                    // Create line to write to file
                    StringBuilder line = new StringBuilder();
                    line.Append(game.Name).Append(";");
                    line.Append(game.Age).Append(";");
                    line.Append(game.Path).Append(";");
                    line.Append(game.Developer).Append(";");
                    line.Append(game.ReleaseDate).Append(";");
                    line.Append(game.DesccriptionPath).Append(";");
                    line.Append(game.LastPlayed).Append(";");
                    line.Append(game.Review).Append(";");
                    line.Append(GetAllImgPaths(game.Images)).Append(";");
                    line.Append(GetAllVideoPaths(game.Videos)).Append(";");

                    sw.WriteLine(line.ToString());
                }
                sw.Close();
            }
        }
        public static void WriteToUserFile(List<Person> users)
        {
            // Write User List in File
            using (StreamWriter sw = File.CreateText(PathFileUsers))
            {
                // Goes to every single user
                foreach (Person user in users)
                {
                    // Create line to write to file
                    StringBuilder line = new StringBuilder();

                    line.Append(user.Name).Append(";");
                    line.Append(user.Password).Append(";");
                    line.Append(user.Age).Append(";");
                    line.Append(user.Active).Append(";");

                    Debug.Print(line.ToString());

                    sw.WriteLine(line.ToString());
                }
                sw.Close();
            }
        }
        public static void WriteToPinFile(string pin)
        {
            // Write User List in File
            using (StreamWriter sw = File.CreateText(PathPin))
            {
                sw.WriteLine(pin);
                sw.Close();
            }
        }
        public static void WriteDescription(string des, string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(des);
                sw.Close();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Check if somethings exists
        
        /// <summary>
        /// Checks if .GameLauncher directory exists 
        /// </summary>
        private static void IsFolder()
        {
            if (!Directory.Exists(PathFolder))
            {
                Directory.CreateDirectory(PathFolder);
            }
        }

        /// <summary>
        /// Checks if Users.csv file exists
        /// </summary>
        private static void IsUser()
        {
            if (!File.Exists(PathFileUsers))
            {
                FileStream fs = File.Create(PathFileUsers);
                fs.Close();
            }
        }

        /// <summary>
        /// Checks if games.csv file exists
        /// </summary>
        private static void IsGames()
        {
            if (!File.Exists(PathFileGames))
            {
                FileStream fs = File.Create(PathFileGames);
                fs.Close();
            }
        }

        /// <summary>
        /// Checks if pin.csv file exists
        /// </summary>
        /// <returns></returns>
        public static bool IsPinFile()
        {
            if (File.Exists(PathPin))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Checks if FailDes.txt file exists and write "<p>Could not find anything</p>" to it
        /// </summary>
        private static void IsFailDes()
        {
            if (!File.Exists(PathFailDec))
            {
                using (StreamWriter sw = File.CreateText(PathFailDec))
                {
                    sw.Write("<p>Could not find anything</p>");
                    sw.Close();
                }
                
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gets all the Folder within a folder
        
        /// <summary>
        /// Gets all folder in a folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns>
        /// string[] with all the folderspaths
        /// </returns>
        public static string[] GetDirectoriesSteamGameNames(string path)
        {
            return Directory.GetDirectories(path);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Gets all Exe files from a folder
        
        /// <summary>
        /// Gets all ".exe" files from a folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns>
        /// string[] with all the exe paths
        /// </returns>
        public static string[] GetExeWith(string path)
        {
            return Directory.GetFiles(path, "*.EXE", SearchOption.AllDirectories);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Creates each time a folder wih the game name
        
        /// <summary>
        /// Creates a new folder with the game name. This folder will be used for all the Pictures / Video and the Description file
        /// </summary>
        /// <param name="name"></param>
        public static void CheckMediaFolder(string name)
        {
            if (name.Contains(":"))
            {
                name = name.Replace(":", " ");
            }

            if (name.Contains(";"))
            {
                name = name.Replace(";", "");
            }

            string path = Info.PathGameMedia + name;
            if (!Directory.Exists(path))
            {
                // if it doesnt exists it will create the Img & Videos folder too
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }

                CreateImgFolder(path);
                CreateVideoFolder(path);
                CreateDescriptionFile(path);
            }

        }
        
        /// <summary>
        /// Create the Img folder within the Media folder
        /// </summary>
        /// <param name="path"></param>
        private static void CreateImgFolder(string path)
        {
            // Creates the img folder
            path += @"\img";
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        /// <summary>
        /// Create the Video folder within the Media folder
        /// </summary>
        /// <param name="path"></param>
        private static void CreateVideoFolder(string path)
        {
            // Creates the video folder
            path += @"\video";
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        /// <summary>
        /// Create the Description file within the Media folder
        /// </summary>
        /// <param name="path"></param>
        private static void CreateDescriptionFile(string path)
        {
            // Creates the video folder
            path += @"\Des.txt";
            if (!File.Exists(path))
            {
                try
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Help methode for Write to file

        /// <summary>
        /// Creates a string for the videos. It will insert a "-" between the videos paths
        /// </summary>
        /// <param name="gameVideos"></param>
        /// <returns>
        /// returns a string with all the Paths of the Videos
        /// </returns>
        private static string GetAllVideoPaths(List<string> gameVideos)
        {
            int pathlength = Info.PathFolder.Length;
            if (gameVideos.Count == 1)
            {
                return "noVideo";
            }
            // Append all game paths together
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < gameVideos.Count - 1; i++)
            {
                str.Append(gameVideos[i].Substring(pathlength)).Append("-");
            }

            str.Append(gameVideos[gameVideos.Count - 1].Substring(pathlength));
            return str.ToString();
        }

        /// <summary>
        /// Creates a string for the Images. It will insert a "-" between the Images paths
        /// </summary>
        /// <param name="gameImages"></param>
        /// <returns>
        /// returns a string with all the Paths of the Images
        /// </returns>
        private static string GetAllImgPaths(List<string> gameImages)
        {
            int pathlength = Info.PathFolder.Length;
            if (gameImages.Count == 1)
            {
                return "noImg";
            }
            // Append all game paths together
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < gameImages.Count - 1; i++)
            {
                str.Append(gameImages[i].Substring(pathlength)).Append("-");
            }

            str.Append(gameImages[gameImages.Count - 1].Substring(pathlength));
            return str.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Help methode for Read to file

        /// <summary>
        /// Splits the string to get each videos path. The path will be added to a list
        /// </summary>
        /// <param name="allVideoPath"></param>
        /// <returns>
        /// A list with all the videos paths
        /// </returns>
        private static List<string> SplitVideos(string allVideoPath)
        {
            List<string> videos = new List<string>();
            string addPath = Info.PathFolder;
            if (allVideoPath == "noVideo")
            {
                videos.Add("noVideos");
                return videos;
            }

            string[] videosArray = allVideoPath.Split('-');

            foreach (string s in videosArray)
            {
                videos.Add(addPath + s);
            }

            return videos;
        }

        /// <summary>
        /// Splits the string to get each images path. The path will be added to a list
        /// </summary>
        /// <param name="allImgPath"></param>
        /// <returns>
        /// A list with all the images paths
        /// </returns>
        private static List<string> SplitImages(string allImgPath)
        {
            List<string> images = new List<string>();
            string addPath = Info.PathFolder;
            if (allImgPath == "noImg")
            {
                images.Add("noImg");
                return images;
            }

            
            string[] imagesArray = allImgPath.Split('-');

            foreach (string s in imagesArray)
            {
                images.Add(addPath + s);
            }

            return images;
        }

        /// <summary>
        /// Reads the description of the game
        /// </summary>
        /// <param name="copiedGames"></param>
        /// <returns>
        /// All games with the game´s. All game´s have a description
        /// </returns>
        private static List<Game> AddDescription(List<Game> copiedGames)
        {
            foreach (Game game in copiedGames)
            {
                string path = game.DesccriptionPath;
                if (game.DesccriptionPath == String.Empty)
                {
                    path = Info.PathFolder + "\\FailDes.txt";
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    game.Desccription = sr.ReadToEnd();
                    sr.Close();
                }
            }

            return copiedGames;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        
        /// <summary>
        /// Find the biggest exe file
        /// </summary>
        /// <param name="paths"></param>
        /// <returns>
        /// a string with the paths of it
        /// </returns>
        public static string GetBiggestFile(string[] paths)
        {
            double tem = 0;
            string biggestPath = "";

            foreach (string path in paths)
            {
                FileInfo fi = new FileInfo(path);
                if (!path.Contains("install") && !path.Contains("Crash"))
                {
                    if (tem < fi.Length)
                    {
                        tem = fi.Length;
                        biggestPath = path;
                    }
                }
            }

            return biggestPath;
        }
    }
}
