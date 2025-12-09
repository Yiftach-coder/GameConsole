using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UserList
    {
        private static List<Users> users = new List<Users>();
        public static bool Add(Users user)
        {
            bool exists = users.Any(u => user.username == u.username);
            if(!exists) users.Add(user);
            return !exists;
        }

        public static bool UpdateUsername(string currentUsername, string newUsername)
        {
            if (users.Any(u => u.username == newUsername))
            {
                return false;
            }
            var user = users.FirstOrDefault(u => u.username == currentUsername);
            if (user != null)
            {
                user.username = newUsername;
                return true; 
            }
            return false; 
        }


        public static bool Login(string Username, string password)
        {
            return users.Any(user => user.username == Username && user.password == password);
        }
        
        private UserList()
        {
        }
        
    }
}
