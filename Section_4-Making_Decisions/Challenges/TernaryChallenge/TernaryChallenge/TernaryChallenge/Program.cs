using System;
using System.Net.Http.Headers;

namespace TernaryChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have studied ternary operators and their usage so here is a small challenge for you.
            //Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

            //If the input value is not an integer value, it should print to the console "Not a valid Temperature".

            //And if the input value is the valid integer then it should work as mentioned below.

            //- If input temperature value is <= 15 it should write "it is too cold here" to the console.

            //- If input temperature value is >= 16 and is <= 28 it should write "it is ok" to the console.

            //- If the input temperature value is > 28 it should write "it is hot here" to the console.

            //Make sure to use ternary operators and not if statements to check for the three conditions,
            //however you can use if statement for the other conditions like to check if the entered
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            Console.WriteLine("Enter the Current Temperature: ");
            inputValue = Console.ReadLine();

            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                temperatureMessage = inputTemperature <= 15 ? "It's too cold outside"
                    : (inputTemperature >= 16 && inputTemperature <= 28) ? "it is nice outside"
                    : "It's hot";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("This is not a valid integer");
            }
        }
    }
}
