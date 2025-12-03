using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        public string GameName { get; set; }
        public int Score { get; set; }
        public DateTime date { get; set; }

        public HighScore(string gameName, int score)
        {
            GameName = gameName;
            Score = score;
            date = DateTime.Now;
        }
    }
}
