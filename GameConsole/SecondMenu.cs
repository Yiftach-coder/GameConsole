using GameConsole.Base;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class SecondMenu : MenuScreen
    {
        public SecondMenu() : base("Menu")
        {
            Add(new MenuItem("Go to The User Proflie", new UserProfile()));
            Add(new MenuItem("Go to Games Menu", new MenuGames()));
        }
    }
}
