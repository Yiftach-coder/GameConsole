using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MainMenu:MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            Add(new MenuItem("Register", new RegisterScreen()));
            Add(new MenuItem("Login", new LoginScreen()));

        }
    }
}
