using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UsernameUpdate:Screen
    {
        private Users user;

        public UsernameUpdate(Users user) : base("Update Username")
        {
            this.user = user;
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter your new username: ");
            string NewuserName = Console.ReadLine();
            if (UserList.UpdateUsername(user.username, NewuserName))
            {
                CenterText("Username updated successfully! Press any key to continue...");
                CenterText($"Your new Username is: {NewuserName}");
                Console.ReadKey();
                
            }
            else
            {
                CenterText("Username already exists. Please try a different username. Press any key to go back...");
                
            }
        }
    }
}
