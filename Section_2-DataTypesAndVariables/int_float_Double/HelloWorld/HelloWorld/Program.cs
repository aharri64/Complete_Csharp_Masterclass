using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            // declaring a variable
            int num1;

            // assigning(initializing) a value to a variable
            int num1 = 13;

            // declaring and initializing on the same line
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            float f1 = 3.1415f;
            float f2 = 5.1f;

            // Using concatenation 
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + num2 + " is " + sumD);
            Console.Read();
        }
        
    }
}
