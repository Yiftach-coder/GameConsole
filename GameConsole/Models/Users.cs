using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class Users
    {
        public List<HighScore> HighScores;
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Users(string name, string username, string password)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            List<HighScore> HighScores = new List<HighScore>();
        }
        
    }
}
