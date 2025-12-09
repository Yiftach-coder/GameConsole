using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UserProfile:MenuScreen
    {
        private Users user;
        public UserProfile(Users user) : base("User Profile")
        {
            CenterText("Welcome to Your Profile!");
            Add(new MenuItem("View Profile Details", new Profile()));
            Add(new MenuItem("Change Password", new PasswordUpdate(user)));
            Add(new MenuItem("Change Username", new UsernameUpdate(user)));
            
        }
    }
}
