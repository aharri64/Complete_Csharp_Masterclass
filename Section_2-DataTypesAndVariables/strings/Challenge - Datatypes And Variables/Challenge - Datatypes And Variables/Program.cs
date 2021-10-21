using System;

namespace Challenge___Datatypes_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte smallByte = 42;
            sbyte verySmallByte = -42;
            int num = 500;
            long big = 555555;
            float decima = 2.33f;
            double myNewDouble = .1;
            string text = "I control text";
            string number = "23";
            int toInt = Int32.Parse(number);

            Console.WriteLine(smallByte);
            Console.WriteLine(verySmallByte);
            Console.WriteLine(num);
            Console.WriteLine(big);
            Console.WriteLine(decima);
            Console.WriteLine(myNewDouble);
            Console.WriteLine(text);
            Console.WriteLine(number);
            Console.WriteLine(toInt);
        }
    }
}
