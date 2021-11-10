using System;

namespace HelloWorld
{   
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);
            
            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if(numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }

            if(numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }

        


    }
}
