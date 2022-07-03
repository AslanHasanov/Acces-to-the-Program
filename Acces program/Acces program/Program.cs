using System;
using System.Collections.Generic;

namespace Acces_program
{
    internal class Program
    {
        public static List<UserRegister> persons { get; set; } = new List<UserRegister>();
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
    class UserValidator : UserRegister
    {
        public UserValidator(string name, string surName, string email, string password1, string password2)
            : base(name, surName, email, password1, password2)
        {

        }

        public static bool IsAllInformationsTrue(string name, string surName, string email, string password1, string password2)
        {
            if (IsNameTrue(name) & IsSurnameTrue(surName) & IsEmailTrue(email) & IsPasswordTrue(password1, password2))
            {
                return true;
            }
            return false;
        }

        public static bool IsNameTrue(string name)
        {
            if (name.Length >= 3 && name.Length <= 30)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Name length is false");
                return false;
            }
        }
        public static bool IsSurnameTrue(string surName)
        {
            if (surName.Length >= 5 && surName.Length <= 20)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Surname length is false");
                return false;
            }
        }
        public static bool IsEmailTrue(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                char character = '@';
                if (email[i] == character)
                {
                    return true;

                }
            }
            Console.WriteLine("Email format is false");
            return false;
        }
        public static bool IsPasswordTrue(string password1, string password2)
        {
            if (password1 == password2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Entered password is false");
                return false;
            }
        }

    }
    class UserLoginValidator
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserLoginValidator(string email, string password)
        {
            Email = email;
            Password = password;
        }


        public static bool IsLoginEmailTrue(List<UserRegister> persons, string email)
        {

            foreach (UserRegister person in persons)
            {
                if (person.Email == email)
                {
                    return true;
                }
            }
            Console.WriteLine("Email not specified");
            return false;

        }
        public static bool IsLoginPasswordTrue(List<UserRegister> persons, string password)
        {
            foreach (UserRegister person in persons)
            {
                if (person.Password == password)
                {
                    return true;
                }
            }
            Console.WriteLine("Password not specified");
            return false;
        }
    }
}
