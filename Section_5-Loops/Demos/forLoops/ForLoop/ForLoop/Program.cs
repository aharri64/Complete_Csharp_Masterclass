using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            Console.Read();

        }
    }
}
