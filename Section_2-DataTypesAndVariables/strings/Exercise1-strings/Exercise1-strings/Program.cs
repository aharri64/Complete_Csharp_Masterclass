using System;

namespace Exercise1_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine(readInput.ToUpper());
            Console.WriteLine(readInput.ToLower());
            Console.WriteLine(readInput.Trim());
            Console.WriteLine(readInput.Substring(2, 6));
        }
    }
}
