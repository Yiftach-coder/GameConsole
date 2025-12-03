using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class UserList
    {
        public void Add(Users user)
        {
            users.Add(user);
        }
        public static List<Users> getInstance()
        {
            return users;
        }

        private static List<Users> users = new List<Users>();
        private UserList()
        {
        }
        
    }
}
