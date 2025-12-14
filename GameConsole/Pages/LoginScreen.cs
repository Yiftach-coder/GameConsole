using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
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

            Console.Write("\nUserName: ");
            string LoginUsername = Console.ReadLine();

            Console.Write("\nPassword: ");
            string LoginPassword = Console.ReadLine();

           
            if (UserList.Login(LoginUsername, LoginPassword))
            {
                CenterText("Logged in Successful! Press any key to continue...");
                Console.ReadKey();
                Users user = new Users("", LoginUsername, LoginPassword);
                Screen menu = new SecondMenu(user);
                menu.Show();

            }
            else
            {
                CenterText("Invalid UserName or Password. Please try again.");
                Console.ReadKey();
                Screen back = new MainMenu();
                back.Show();
            }
            
        }
    }
}
