using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safety - "properties start with a capital letter"
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}, I am a {jobTitle}, and I am {age} year's old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 20000;
            jobTitle = "developer";
            Console.WriteLine("Object Created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // clean up statements
            Console.WriteLine("Deconstruction of Member Object");
            Debug.Write("Deconstruction of Member Object");
        }
    }
}
