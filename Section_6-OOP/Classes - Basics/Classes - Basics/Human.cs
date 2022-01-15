using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    // this class is a blueprint for a datatype 

    // create a public variable lastName of type string.
    // change the IntroduceMyself method, so it tells the whole name.
    // create two objects with full information about themself - firstName and lastName
    
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;

        //Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // parameterized constructor
        public Human(string myFirstName, string lastName, string eyeColor, int age )
        {
            //Two different methods to achieve the same thing
            //Either rename
            firstName = myFirstName;
            // or use the this keyword
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }

        public Human(string myFirstName, string lastName, string eyeColor)
        {
            //Two different methods to achieve the same thing
            //Either rename
            firstName = myFirstName;
            // or use the this keyword
            this.lastName = lastName;
            this.eyeColor = eyeColor;

        }
        public Human(string myFirstName, string lastName)
        {
            //Two different methods to achieve the same thing
            //Either rename
            firstName = myFirstName;
            // or use the this keyword
            this.lastName = lastName;

        }
        public Human(string myFirstName)
        {
            //Two different methods to achieve the same thing
            //Either rename
            firstName = myFirstName;
            // or use the this keyword

        }

        // member method
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && firstName != null && eyeColor != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, I have {eyeColor} eyes and I am {age} year's old");
            }
            else if (age == 1)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, I have {eyeColor} eyes and I am {age} year old");
            }
            else if (age == 0 && lastName != null && firstName != null && eyeColor != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, I have {eyeColor} eyes");
            }
            else if (age == 0 && lastName != null && firstName != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}");
            }
            else if (age == 0 && lastName != null)
            {
                Console.WriteLine($"Hi, I'm {firstName}");
            }
        }
    }
}
