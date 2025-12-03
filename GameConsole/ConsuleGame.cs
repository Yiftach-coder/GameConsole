using GameConsole.Base;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class ConsuleGame
    {
        private Screen MainPage;

        public ConsuleGame()
        {
            MainPage = new WelcomeScreen();
        }
        public void StartApp()
        {
            MainPage.Show();
        }
    }
}