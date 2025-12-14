using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class Profile:Screen
    {
        private Users user;
        public Profile(Users user) : base("Profile")
        {
            this.user = user;
        }
        public override void Show()
        {
            base.Show();
            CenterText("Here are your profile details");
            CenterText("Your Username: " + user.username);
            CenterText("Your password: " + user.password);
            CenterText("Press any key to go back...");
            Console.ReadKey();
        }
    }
}
