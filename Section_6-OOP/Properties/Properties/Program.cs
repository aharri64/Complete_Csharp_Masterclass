using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            //box.length = 3;
            //box.SetLength(3);
            //box.Height = 4;
            //box.Width = 5;

            Console.WriteLine($"Front Surface is {box.FrontSurface}");

            box.DisplayInfo();
        }
    }
}
