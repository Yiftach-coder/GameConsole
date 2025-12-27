using GameConsole.Base;
using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class Game:Screen
    {
        private IGamePlay Games;
        public Game(IGamePlay game) : base(game.Name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Games = game;
        }
        public override void Show()
        {
            base.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText($"Starting {Games.Name}...");
            Console.ReadKey();
            Console.Clear();
            Games.Play();
            CenterText($"Game Over! Your score: {Games.Score}");
        }
    }
}
