using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringAndLogginIn
{
    class Program
    {

        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("-------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart Program");
            }
        }

    }
}
