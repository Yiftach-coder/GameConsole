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
    internal class PasswordUpdate:Screen
    {
        private Users user;
        public PasswordUpdate(Users user) : base("Update Password")
        {
            this.user = user;
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter your new password: ");
            string NewPassword = Console.ReadLine();
            if (UserList.UpdatePassword(user.username, user.password, NewPassword))
            {
                CenterText("Password updated successfully! Press any key to continue...");
                CenterText($"Your new Password is: {NewPassword}");
                Console.ReadKey();
            }
            
        }
    }
}
