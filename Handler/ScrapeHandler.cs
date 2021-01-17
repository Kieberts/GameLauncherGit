using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using GameLauncher.Objects;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GameLauncher.Handler
{
    public class ScrapeHandler
    {
        private static readonly Information.Information Infos = new Information.Information();
        private readonly string _path = Infos.PathGameMedia;

        /// <summary>
        /// ScrapaData methode will search the web of information like Developer or Release Date
        /// </summary>
        /// <param name="gameName"></param>
        /// <returns>
        /// if it finds the gamepage it will return a game with all the information. It will also download the pictures and videos to files.
        /// </returns>
        public Game ScrapeData(string gameName)
        {
            HtmlWeb web = new HtmlWeb();

            // Creates a new Game ... it will add the properties later on
            Game game = new Game
            {
                Name = gameName
            };

            // Checks Game Name
            gameName = ChangeString(gameName);

            // Gets the right page for the game
            HtmlDocument page = GetPageResults(web, web.Load("https://store.steampowered.com/search/?term=" + gameName), "//*[@id='search_resultsRows']//a", true);
            if (page == null)
            {
                // If it is null the game either doesnt exists or it is over 18
                Debug.Print("Error");
                return ErrorGame(game.Name);
            }

            // Gets the game name
            game.Name = GetProperty(page, "//*[@class='apphub_AppName']");

            // For future use of the name, again check it
            if (game.Name.Contains(":"))
            {
                game.Name = game.Name.Replace(":", " ");
            }

            if (game.Name.Contains(";"))
            {
                game.Name = game.Name.Replace(";", " ");
            }

            // Because we cant get the age of every game, it will be 18 just in case
            game.Age = "18";

            // Get the rest information of the gamepage
            game.Developer = GetProperty(page, "//*[@id='developers_list']//a");
            game.ReleaseDate = GetProperty(page, "//*[@class='date']");
            game.Desccription = page.DocumentNode.SelectSingleNode("//*[@id='game_area_description']").OuterHtml;
            game.Review = GetProperty(page, "//*[@class='game_review_summary positive']");

            // Create a folder and download all the information
            FileHandler.CheckMediaFolder(game.Name);
            game = SaveVideo(game, page);
            game = SaveImages(game, page);
            game = SaveDescription(game);

            return game;
        }

        /// <summary>
        /// Writes the Descriptionhtmlcode to file for future use
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        private Game SaveDescription(Game game)
        {
            string desPath = _path;

            // Modify name
            string name = game.Name;
            

            // Modifyy Path to get write place to write
            desPath += name;
            desPath += @"\Des.txt";

            // Donwload Description to seperate file
            FileHandler.WriteDescription(game.Desccription, desPath);
            game.DesccriptionPath = desPath;

            return game;
        }

        /// <summary>
        /// This will donwload all pictures of the Game to the right path
        /// </summary>
        /// <param name="game"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        private Game SaveImages(Game game, HtmlDocument doc)
        {
            string imgPath = _path;

            // Modify name
            string name = game.Name;

            if (name.Contains(":"))
            {
                name = name.Replace(":", " ");
            }

            if (name.Contains(";"))
            {
                name = name.Replace(";", "");
            }

            imgPath += name;
            imgPath += @"\img";
            List<string> imgList = new List<string>();

            // searches pic from web 
            var images = doc.DocumentNode.SelectNodes("//*[@class='screenshot_holder']//a");
            foreach (var element in images)
            {
                WebClient wClient = new WebClient();

                string src = element.Attributes["href"].Value;

                string createdPath = imgPath + @"\" + src.Remove(src.IndexOf("?")).Substring(src.LastIndexOf('/') + 1);

                // Saves path in list
                imgList.Add(createdPath);

                // downloads picture in Folder
                wClient.DownloadFile(src, createdPath);
            }

            // gives game the string[] with all the paths
            game.Images = imgList;

            return game;
        }

        /// <summary>
        /// This will download all the videos of the game to the right path
        /// </summary>
        /// <param name="game"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        private Game SaveVideo(Game game, HtmlDocument doc)
        {
            string videoPath = _path;

            string name = game.Name;

            if (name.Contains(":"))
            {
                name = name.Replace(":", " ");
            }

            if (name.Contains(";"))
            {
                name = name.Replace(";", "");
            }

            videoPath += name;
            videoPath += @"\video";
            List<string> videoList = new List<string>();

            // searches video from web
            var images = doc.DocumentNode.SelectNodes("//*[@class='highlight_player_item highlight_movie']");

            int index = 0;
            foreach (var element in images)
            {
                WebClient wClient = new WebClient();

                string src = element.Attributes["data-mp4-hd-source"].Value;

                // Modify Path
                string createdPath = src.Remove(src.IndexOf("?"));
                createdPath = createdPath.Substring(src.LastIndexOf('/') + 1);
                createdPath = createdPath.Insert(createdPath.IndexOf("."), index.ToString());

                // Saves path in listx
                index++;
                string finalPath = videoPath + @"\" + createdPath;
                videoList.Add(finalPath);
                // downloads video in Folder
                wClient.DownloadFile(src, finalPath); // BUG Error
            }


            // gives game the string[] with all the paths
            game.Videos = videoList;


            return game;
        }

        /// <summary>
        /// Get InnerText
        /// </summary>
        /// <param name="docGame"></param>
        /// <param name="search"></param>
        /// <returns>
        /// Returns the InnerText of a html string
        /// </returns>
        private string GetProperty(HtmlDocument docGame, string search)
        {
            // returns a string with the Text from the id / class
            return docGame.DocumentNode.SelectSingleNode(search).InnerText;
        }

        /// <summary>
        /// Gets string and checks it for " " - "&" - ":" 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// a checked string
        /// </returns>
        private string ChangeString(string name)
        {
            // Changes / combine the string
            if (name.Contains(" "))
            {
                name = name.Replace(" ", "+");
            }

            if (name.Contains("&"))
            {
                name = name.Replace("&", "%26");
            }

            if (name.Contains(":"))
            {
                name = name.Replace(":", "%3A");
            }

            return name;
        }

        /// <summary>
        /// This will load the steamgamesearchpage. It will select the first game of the list.
        /// Then it will open the spesific game page
        /// </summary>
        /// <param name="web"></param>
        /// <param name="doc"></param>
        /// <param name="searchTurm"></param>
        /// <param name="firstPage"></param>
        /// <returns>
        /// Returns a HtmlDocument which can access the Gamepage 
        /// </returns>
        private HtmlDocument GetPageResults(HtmlWeb web, HtmlDocument doc, string searchTurm, bool firstPage)
        {
            
            HtmlNode restultList = null;
            try
            {
                restultList = doc.DocumentNode.SelectSingleNode(searchTurm);
            }
            catch (Exception)
            {
                // ignored
            }

            // If it could not find it will return null
            if (restultList == null)
            {
                return null;
            }



            if (firstPage)
            {
                if (!web.Load(restultList.Attributes["href"].Value).ToString().Contains("agecheck")) // IF that doenst work = DONT USE IT
                {
                    // Reenter this methode to get to new page
                    return GetPageResults(web, web.Load(restultList.Attributes["href"].Value), "//*[@class='apphub_AppName']", false);
                }
                else
                {
                    Debug.Print("Game is over 18");
                }
            }

            return doc;
        }

        /// <summary>
        /// Error Game
        /// </summary>
        /// <param name="oldName"></param>
        /// <returns>
        /// Returns a game with standard settings
        /// </returns>
        private Game ErrorGame(string oldName)
        {
            return new Game
            {
                Name = oldName,
                Age = "18",
                Desccription = "<p>Error</p>",
                Developer = "Error",
                Favorite = false,
                Images = new List<string>(),
                Videos = new List<string>(),
                LastPlayed = "never",
                Path = "Error",
                ReleaseDate = "Error",
                Review = "Error"
            };
        }

    }
}
