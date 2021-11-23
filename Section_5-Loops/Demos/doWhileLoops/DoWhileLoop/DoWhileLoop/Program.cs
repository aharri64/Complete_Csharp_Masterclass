using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            string wholeText = "";
            int lengthOfText = 0;
            do
            {
                Console.WriteLine("Please enter the name of a friend: ");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            } while (lengthOfText <= 20);

            Console.WriteLine("Thanks, that was enough " + wholeText);

            Console.Read();
        }
    }
}
