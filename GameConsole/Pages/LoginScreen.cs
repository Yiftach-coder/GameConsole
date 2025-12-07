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
            string userNameIsExists = Console.ReadLine();

            Console.Write("\nPassword: ");
            string passwordIsExists = Console.ReadLine();

           
            if (UserList.Login(userNameIsExists, passwordIsExists))
            {
                CenterText("Logged in Successful! Press any key to continue...");
                Screen next = new MenuGames();
                next.Show();
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
