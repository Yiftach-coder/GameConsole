using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class SecondMenu : MenuScreen
    {
        private Users user;
        public SecondMenu(Users user) : base("Menu")
        {
            Add(new MenuItem("Go to The User Proflie", new UserProfile(user)));
            Add(new MenuItem("Go to Games Menu", new MenuGames()));
            this.user = user;
            

        }
    }
}
