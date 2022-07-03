using System;

namespace Acces_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter command : ");
                string command = Console.ReadLine();
                if (command == "/register")
                {
                    Console.Write("Please enter your name :");
                    string name = Console.ReadLine();

                    Console.Write("Please enter your surname :");
                    string surName = Console.ReadLine();

                    Console.Write("Please enter your email adres :");
                    string email = Console.ReadLine();

                    Console.Write("Please enter your password :");
                    string password1 = Console.ReadLine();

                    Console.Write("Please enter password again :");
                    string password2 = Console.ReadLine();
                }
                else if (command == "/login")
                {
                    Console.Write("Enter your email : ");
                    string email = Console.ReadLine();
                    Console.Write("Enter your password :");
                    string password = Console.ReadLine();
                }
                else if (command == "/exit")
                {
                    Console.WriteLine("Bye Bye mr/mrs user :)");
                    break;
                }
                else
                {
                    Console.WriteLine(command + " Not found, please enter available command");
                    Console.WriteLine();
                }
            }
        }
    }
    class UserRegister
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserRegister(string name, string surName, string email, string password1, string password2)
        {
            Name = name;
            SurName = surName;
            Email = email;
            Password = password1;
        }

    }
}
