using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class HistoryScreen:Screen
    {
        private string sortBy;
        public HistoryScreen(string _sortBy) : base("Game history")
        {
            sortBy = _sortBy;
        }
        public override void Show()
        {
            base.Show();
            List<HighScore> GameList;
            if (sortBy == "Overall Score")
            {
                GameList = GameHistory.byScore();
            }
            else if (sortBy == "Game Name")
            {
                GameList = GameHistory.byName();
            }
            else
            {
                GameList = GameHistory.byDate();
            }
            

            if (GameList.Count == 0)
            {
                CenterText("No game history available.");
            }
            else
            {
                Console.WriteLine();
                foreach (var game in GameList)
                {
                    Console.WriteLine($"Game: {game.GameName} | Score: {game.Score} | Date: {game.date}");
                }
                
                Console.ReadKey();
                Screen Menu = new MenuHistory();
                Menu.Show();
            }
        }
    }
}

