using GameConsole.Base;
using GameConsole.Games;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameHistory:Screen
    {
        private Users user;
        public GameHistory(Users user) : base("Profile")
        {
            this.user = user;
        }
        public override void Show()
        {
            base.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText($"{user.username}'s Game History:");
            
            Console.ReadKey();
        }
    }
}
