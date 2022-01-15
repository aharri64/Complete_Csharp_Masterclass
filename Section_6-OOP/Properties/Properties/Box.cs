using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        //member variables
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Length should be higher that 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.height * this.length * this.width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length}, height is {height} and width is " +
                              $"{width} so the volume is {GetVolume()}");
        }


    }
}
