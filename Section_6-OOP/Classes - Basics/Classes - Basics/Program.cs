using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner", "blue", 25);
            sissy.IntroduceMyself();

            Human william = new Human("William", "Foss", "Brown", 38);
            william.IntroduceMyself();

            Human stormy = new Human("Stormy", "O'Dell", "Green", 42);
            stormy.IntroduceMyself();

            Human baby = new Human("baby", "Little", "Blue", 1);
            baby.IntroduceMyself();

            Human bob = new Human("Bob", "Marley", "brown");
            bob.IntroduceMyself();

            Human dave = new Human("Dave", "Batista");
            dave.IntroduceMyself();

            Human basicHuman = new Human();


            Console.ReadKey();
        }
    }
}
