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
    internal class MenuGames : MenuScreen
    {
        private Users user;
        public MenuGames(Users user) : base("Games Menu")
        {
            Add(new MenuItem("Flappy bird", new Game(new FluffyBirdGame(user))));
            Add(new MenuItem("PacManGame", new Game(new PacManGame(user))));
            Add(new MenuItem("TetrisGame", new Game(new TetrisGame(user))));
            this.user = user;
        }
    }
}