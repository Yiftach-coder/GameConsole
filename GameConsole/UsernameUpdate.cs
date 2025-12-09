using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class UsernameUpdate:Screen
    {
        public UsernameUpdate() : base("Update Username")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter your new username: ");
            string NewuserName = Console.ReadLine();
            if(UserList.UpdateUsername(Users.username, NewuserName))
            {
                CenterText("Username updated successfully to: " + NewuserName);
                CurrentUser.CurrentUsername = NewuserName;
            }
            else
            {
                CenterText("Username update failed. The username may already exist.");
            }



            Screen userProfile = new UserProfile();
            userProfile.Show();
        }
    }
}
