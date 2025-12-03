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
        public void Add(Users user)
        {
            users.Add(user);
        }
        public static List<Users> getInstance()
        {
            return users;
        }
        public static void RegisterUser(string name, string username, string password)
        {
            users.Add(new Users(name, username, password));
        }
        public static Users Login(string Username, string password)
        {
            return users.Find(user => user.username == Username && user.password == password);
        }
        
        private UserList()
        {
        }
        
    }
}
