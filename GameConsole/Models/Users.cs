﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class Users
    {
        public List<HighScore> HighScores = new List<HighScore>();
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Users(string name, string username, string password)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            HighScore n = new HighScore("Fluffy Bird", 0);
            HighScore n1 = new HighScore("Tetris", 0);
            HighScore n2 = new HighScore("PacMan", 0);
            HighScores.Add(n);
            HighScores.Add(n1);
            HighScores.Add(n2);
        }
        public void HighscoreReplacer(HighScore newhs)
        {
            bool flag = false;
            foreach (HighScore hs in HighScores)
            {
                if (hs.GameName == newhs.GameName)
                {
                    if (hs.Score < newhs.Score)
                    {
                        hs.Score = newhs.Score;
                        flag = true;
                    }
                }
            }
            if (!flag)
                HighScores.Add(newhs);
        }
        public List<HighScore> GetHighScores()
        {
            return HighScores;
        }
    }
}