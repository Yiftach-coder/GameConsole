using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
	internal class MenuItem
	{
		public string DisplayName
		{
			get; set;
		}
		public Screen Screen
		{
			get; set;
		}

		public MenuItem(string displayName, Screen screen)
		{
			this.DisplayName = displayName;
			this.Screen = screen;
		}

        public MenuItem(string v, RegisterScreen registerScreen)
        {
            this.DisplayName = v;
            this.Screen = registerScreen;
        }
		public MenuItem(string v, LoginScreen loginScreen)
        {
			this.DisplayName = v;
			this.Screen = loginScreen;
        }
    }
}
