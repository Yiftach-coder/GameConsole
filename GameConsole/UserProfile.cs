using GameConsole.Base;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class UserProfile:MenuScreen
    {
        public UserProfile() : base("User Profile")
        {
            CenterText("Welcome to Your Profile!");
            Add(new MenuItem("View Profile Details", new Profile()));
            Add(new MenuItem("Change Password", new PasswordUpdate()));
            Add(new MenuItem("Change Username", new UsernameUpdate()));

        }
        
    }
}
