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

            string name, userName, password;
            List<Users> usersList = UserList.getInstance();

            Console.Write("\nName: ");
            name = Console.ReadLine();

            Console.Write("\nUserName: ");
            userName = Console.ReadLine();

            Console.Write("\nPassword: ");
            password = Console.ReadLine();

            while (true)
            {

                bool isExists = false;

                foreach (Users user1 in usersList)
                {

                    if (userName == user1.username)
                    {
                        CenterText("UserName already exists. Please choose a different UserName.");
                        isExists = true;
                        break;
                    }

                }

                if (!isExists) break;

                Console.Write("\nUserName: ");
                userName = Console.ReadLine();

            }

            CenterText("Register Successful! Press any key to continue...");

            Users user = new Users(name, userName, password);
            usersList.Add(user);


            CenterUserName(user.username);
            Console.ReadKey();
            
            Screen next = new MainMenu();
            next.Show();

        }

    }    
}
