using GameConsole.Base;
using GameConsole.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MenuGames:MenuScreen
    {
        public MenuGames() : base("Games Menu")
        { 
            Add(new MenuItem("Flappy bird", new Game(new FluffyBirdGame())));
            Add(new MenuItem("PacManGame", new Game(new PacManGame())));
            Add(new MenuItem("TetrisGame", new Game(new TetrisGame())));
        }
    }
}
