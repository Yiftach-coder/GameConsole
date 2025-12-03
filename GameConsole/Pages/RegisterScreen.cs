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
    internal class RegisterScreen:Screen
    {
        public RegisterScreen() : base("Register Screen")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Please enter your details to register:");
            string name = " ", userName = " ", password = " ";
            bool isExists = false;
            List<Users> usersList = UserList.getInstance();
            Users user = new Users(name, userName, password);
            while (true)
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("UserName: ");
                userName = Console.ReadLine();
                Console.WriteLine("Password: ");
                password = Console.ReadLine();
                isExists = true;
                foreach (Users user1 in UserList.getInstance())
                {
                    
                    if (userName == user1.username)
                    {
                        CenterText("UserName already exists. Please choose a different UserName.");
                        Console.ReadKey();
                        isExists = false;
                        break;
                    }

                }
                if (isExists)
                {
                    break;
                }
            }
            
            CenterText("Register Successful! Press any key to continue...");
            usersList.Add(user);
            CenterUserName(user.username);
            Console.ReadKey();
            user = new Users(name, userName, password);

            Screen next = new MainMenu();
            next.Show();

        }

    }    
}
