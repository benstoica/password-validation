using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Password Validation");
            Console.WriteLine("Hello, welcome to the Password Validation. To start, please create your username:");

            string userName = Console.ReadLine();
            string password = "";
            Console.WriteLine("Please create a password:");

            ConsoleKeyInfo pass = Console.ReadKey(true);
            while (pass.Key != ConsoleKey.Enter)
            {
                if (pass.Key != ConsoleKey.Backspace)
                {
                    password += pass.KeyChar;
                    pass = Console.ReadKey(true);
                }
                else if (pass.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password)) 
                    {
                        password = password.Substring(0, password.Length - 1);
                    }

                    pass = Console.ReadKey(true);
                }
            }
            for (int i = 0; i < password.Length; i++) 
            {
                Console.Write("*");
            }

            Console.WriteLine(" ");
            Console.WriteLine("You've created your credentials, now let's login!");


            Console.WriteLine("Username:");
            while (Console.ReadLine() != userName)
            {
                Console.WriteLine("Sorry, you don't exist in our system! Please enter your username:");
                
            }

            Console.WriteLine("Password:");
            int loginAttempts = 0;

            do
            {
                loginAttempts++;
                if (loginAttempts == 3)
                {
                    Console.WriteLine("Sorry, too many incorrect password attempts. The program will now close.");
                    System.Environment.Exit(1);
                }

                else if (Console.ReadLine() == password)
                {
                    Console.WriteLine($"Login successful! Welcome {userName}!");
                    System.Environment.Exit(1);
                }

            } while (Console.ReadLine() != password);

        }
    }
}




