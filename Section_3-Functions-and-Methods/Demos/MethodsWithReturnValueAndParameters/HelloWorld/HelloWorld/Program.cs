using System;

namespace HelloWorld
{   
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Devide(25,13));
            Console.Read();
        }
   
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
