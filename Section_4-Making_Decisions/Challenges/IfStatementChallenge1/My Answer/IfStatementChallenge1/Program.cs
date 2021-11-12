using System;

namespace IfStatementChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            string username = "Batman5";

            Console.WriteLine("Please enter your username");
            string attemptedUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string attemptedPassword = Console.ReadLine();

            if (attemptedUsername == username && attemptedPassword == password)
            {
                Console.WriteLine($"Welcome {username}");
            }
            else
            {
                Console.WriteLine("You have entered in a wrong username and/or password");
            }

            Console.ReadKey();
        }
    }
}
