using System;

namespace ChallengeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Stormy";
            string friend2 = "William";
            string friend3 = "Joe";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Hi " + friendName + " , my friend!");
        }
    }
}
