using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Amir";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerCaseMessage = message.ToLower();
            int MessageLength = message.Length;

            bool ContainsName = message.Contains("Name"); //Checks if the message contains "Name"
            bool ContainsLowerName = message.Contains("name"); //Same as above, HOWEVER, the .Contains function IS CASE SENSETIVE
            bool Contains_Name = messsage.ToUpper().Contains("NAME"); //Not case sensetive variant, OOP allows multiple functions on one variable

            char FirstLetter = message[0]; //First character in message
            char LastLetter = message[(phrase_length - 1)]; //Last character in message
        
            int index = phrase.IndexOf("name"); //Gets the index of "name", the position the first char is in
            string substring = phrase.Substring(index); //Returns the rest of the message after the index
            string second_word = phrase.Substring(1,2); //Returns substrings
            
            Console.WriteLine(message);
            //Console.WriteLine(capsMessage);
            //Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }   
    }
}
