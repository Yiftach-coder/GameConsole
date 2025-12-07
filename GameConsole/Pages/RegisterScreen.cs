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
    internal class RegisterScreen:Screen
    {
        public RegisterScreen() : base("Register Screen")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Please enter your details to register:");

            string name, userName, password;
            
            Console.Write("\nName: ");
            name = Console.ReadLine();

            Console.Write("\nUserName: ");
            userName = Console.ReadLine();

            Console.Write("\nPassword: ");
            password = Console.ReadLine();

            Users user = new Users(name, userName, password);

            if (!UserList.Add(user)) 
            {
                while (true)
                {
                    CenterText("Username already exists. Please enter a different username.");
                    Console.Write("\nUserName: ");
                    userName = Console.ReadLine();
                    user.username = userName;
                    if (UserList.Add(user))
                    {
                        
                        break;
                    }
                }
            }

            CenterText("Register Successful! Press any key to continue...");
            UserList.Add(user);


            CenterUserName(user.username);
            Console.ReadKey();
            
            Screen next = new MainMenu();
            next.Show();

        }
    }    
}
