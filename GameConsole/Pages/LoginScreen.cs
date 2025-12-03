using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class LoginScreen:Screen
    {
        public LoginScreen() : base("Login")
        {
        }
        public override void Show()
        {
            base.Show();
            

            CenterText("Please Enter Your UserName and Password: ");
            Console.WriteLine("UserName: ");
            string userNameIsExists = Console.ReadLine();
            Console.WriteLine("Password: ");
            string passwordIsExists = Console.ReadLine();
            bool isFound = false;
            List<Users> RegisteredUsers = UserList.getInstance(); 
            foreach (Users user in RegisteredUsers)
            {
                if (userNameIsExists == user.username && passwordIsExists == user.password)
                {
                    CenterText("Login Successful! Press any key to continue...");
                    CenterUserName(userNameIsExists);
                    Console.ReadKey();
                    isFound = true;
                }
            }
            if (!isFound)
            {
                CenterText("User doesn't exists. You need to Register before you login.");
                CenterText("Press any key to go back to Main Menu...");
                Console.ReadKey();
                Screen back = new MainMenu();
                back.Show();
            }
            Screen next = new MenuGames();
            next.Show();
        }
    }
}
