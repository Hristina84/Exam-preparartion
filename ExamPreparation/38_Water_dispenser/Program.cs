using System;

namespace _38_Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int glassVolume = int.Parse(Console.ReadLine());


            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int totalVolume = 0;

            while (totalVolume <= glassVolume)
            {
                string button = Console.ReadLine();

                if (button == "Easy")

                    sum1 += 50;

                if (button == "Medium")

                    sum2 += 100;

                if (button == "Hard")

                    sum3 += 200;

                totalVolume = sum1 + sum2 + sum3;


            }
            int difference = totalVolume - glassVolume;

            if (difference > 0)
            {
                Console.WriteLine($"{difference}ml has been spilled.");
            }
            else
            {
                Console.WriteLine("The dispenser has been tapped 5 times.");
            }
        }
    }
}
