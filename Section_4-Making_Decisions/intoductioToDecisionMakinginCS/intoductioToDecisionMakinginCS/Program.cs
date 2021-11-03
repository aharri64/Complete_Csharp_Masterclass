using System;

namespace intoductioToDecisionMakinginCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the temperature outside: ");
            int temperature = Int32.Parse(Console.ReadLine());

            if (temperature < 50)
            {
                Console.WriteLine("Take a Coat");
            }
            else if (temperature == 50)
            {
                Console.WriteLine("It is 50 degrees");
            }
            else
            {
                Console.WriteLine("It is nice and warm");
            }
            Console.ReadKey();
        }
    }
}
