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
           
            foreach (Users u in users)
            {
                if (u.username == user.username)
                {
                    
                    return false;
                }
            }
            
            users.Add(user);
            return true;
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
