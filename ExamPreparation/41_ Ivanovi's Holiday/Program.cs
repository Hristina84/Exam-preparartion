using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41__Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();
            double price = 0;
            double transportPrice = 0;

            if (destination == "Miami")
            {
                if (nights >= 1 && nights <=10 )
                { price = (nights * (2 * 24.99 + 3 * 14.99)) + (nights * (2 * 24.99 + 3 * 14.99)) * 0.25; }
                else if (nights >= 11 && nights <= 15)
                { price = (nights * (2 * 22.99 + 3 * 11.99)) + (nights * (2 * 22.99 + 3 * 11.99)) * 0.25; }
                else
                { price = (nights * (2 * 20.00 + 3 * 10.00)) + (nights * (2 * 20.00 + 3 * 10.00)) * 0.25; }
            }
            else if (destination == "Canary Islands")
            {
                if (nights >= 1 && nights <= 10)
                { price = (nights * (2 * 32.50 + 3 * 28.50)) + (nights * (2 * 32.50 + 3 * 28.50)) * 0.25; }
                else if (nights >= 11 && nights <= 15)
                { price = (nights * (2 * 30.50 + 3 * 25.60)) + (nights * (2 * 30.50 + 3 * 25.60)) * 0.25; }
                else
                { price = (nights * (2 * 28.00 + 3 * 22.00)) + (nights * (2 * 28.00 + 3 * 22.00)) * 0.25; }
            }
            else if (destination == "Philippines")
            {
                if (nights >= 1 && nights <= 10)
                { price = (nights * (2 * 42.99 + 3 * 39.99)) + (nights * (2 * 42.99 + 3 * 39.99)) * 0.25; }
                else if (nights >= 11 && nights <= 15)
                { price = (nights * (2 * 41.00 + 3 * 36.00)) + (nights * (2 * 41.00 + 3 * 36.00)) * 0.25; }
                else
                { price = (nights * (2 * 38.50 + 3 * 32.40)) + (nights * (2 * 38.50 + 3 * 32.40)) * 0.25; }
            }
            if (transport == "train")
            { transportPrice = 2 * 22.30 + 3 * 12.50; }

            else if (transport == "bus")
            { transportPrice = 2 * 45.00 + 3 * 37.00; }

            else if (transport == "airplane")
            { transportPrice = 2 * 90.00 + 3 * 68.50; }

            Console.WriteLine($"{ (price + transportPrice):f3}");
        }
    }
}
