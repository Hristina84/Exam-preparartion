using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string boxes = Console.ReadLine();

            int boxCount = width * lenght * height;

            while (boxes != "Done")
            {
                int box = int.Parse(boxes);

                boxCount -= box;

                if (boxCount <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(boxCount)} Cubic meters more.");
                    return;
                }

                boxes = Console.ReadLine();
            }
            Console.WriteLine($"{boxCount} Cubic meters left.");
        }
    }
}
