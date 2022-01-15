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
        private int height;
        //public int width;
        private int volume;

        public int FrontSurface
        {
            get
            {
                return height * length;
            }
        }

        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return GetVolume();
            }
            set
            {
                volume = value;
            }
            
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public void SetLength(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Length should be higher that 0");
            }
            this.length = length;
        }


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.height * this.length * this.Width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length}, height is {height} and width is " +
                              $"{Width} so the volume is {Volume}");
        }


    }
}
