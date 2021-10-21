using System;

namespace StringsChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string EnteredString = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            string keyCharacter = Console.ReadLine();
            Console.WriteLine(EnteredString.IndexOf(keyCharacter));

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine(String.Format("Your name is {0} {1}", firstName, lastName));

            Console.Read();

        }
    }
}
