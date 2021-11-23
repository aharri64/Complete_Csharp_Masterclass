using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string entry = "";
            while (entry == "")
            {
                Console.WriteLine("Please enter something: ");
                entry = Console.ReadLine();

                counter++;
                Console.WriteLine($"Current count is {counter}");
            }

            Console.WriteLine("You entered a character, game over.");
            Console.Read();
        }
    }
}
