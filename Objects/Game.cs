using System.Collections.Generic;
using System.Drawing;

namespace GameLauncher.Objects
{
    /// <summary>
    /// Game instance
    /// </summary>
    public class Game
    {
        public string Name { get; set; }
        public string Age { get; set; } 
        public string Path { get; set; }
        public string Developer { get; set; }
        public string ReleaseDate { get; set; }
        public string Desccription { get; set; }
        public string DesccriptionPath { get; set; }
        public string LastPlayed { get; set; }
        public string Review { get; set; } 
        public List<string> Images  { get; set; } 
        public List<string> Videos  { get; set; } 
        public bool Favorite { get; set; }
    }
}
