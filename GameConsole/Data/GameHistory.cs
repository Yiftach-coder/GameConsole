using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class GameHistory
    {
        private static List<HighScore> highScores = new List<HighScore>();
        private GameHistory()
        {
        }
        public static void Addhistory(string gameName, int score)
        {
            HighScore highScore = new HighScore(gameName, score);
            highScores.Add(highScore);
        }
        
        public static List<HighScore> byScore()
        {
            highScores.Sort((a, b) => b.Score.CompareTo(a.Score));
            return highScores;
        }
        public static List<HighScore> byName()
        {
            highScores.Sort((a, b) => a.GameName.CompareTo(b.GameName));
            return highScores;
        }
        public static List<HighScore> byDate()
        {
            highScores.Sort((a, b) => b.date.CompareTo(a.date));
            return highScores;
        }
    }
}
