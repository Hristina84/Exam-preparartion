using System;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
             double price = 0;

            if (n < 20 && time == "day")

            {
                price = 0.70 + n * 0.79;
                Console.WriteLine(price);
            }

            else if (n < 20 && time == "night")
            {
                price = 0.70 + n * 0.90;
                Console.WriteLine(price);
            }

            else if (n >= 20 && n <100)
            {
                price = n * 0.09;
                Console.WriteLine(price);
            }
            else if (n >= 100)
            {
                price = n * 0.06;
                Console.WriteLine(price);
            }



        }
    }
}
