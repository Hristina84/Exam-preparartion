using System;

namespace _01.Lutenica
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomato = double.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            double totalLutenica = tomato / 5;
            var boxes = totalLutenica / Y;
            var jars = totalLutenica / 0.535;

            if (boxes >= X)
            {
                Console.WriteLine($"{Math.Round(boxes - X)} boxes left.");
                Console.WriteLine($"{Math.Round(jars - (X * Y))} jars left.");
            }

            else

            {
                Console.WriteLine($"{Math.Round(X -boxes)} more boxes needed.");
                Console.WriteLine($"{Math.Round((X * Y)- jars)} more jars needed.");
            }

            Console.WriteLine($"Total lutenica:{totalLutenica} kilograms.");

        }
    }
}
