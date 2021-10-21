using System;

namespace StringsChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            char searchInput = Console.ReadLine()[0];

            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("The index of the character {0} in the string is {1}", searchInput, searchIndex);

            //Console.WriteLine(EnteredString.IndexOf(keyCharacter));

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is {0}.", fullName);


            Console.ReadKey();

        }
    }
}
