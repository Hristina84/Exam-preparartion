using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passenger = int.Parse(Console.ReadLine());
            int stopsCount = int.Parse(Console.ReadLine());

            int passengersDown = 0;
            int passengersUp = 0;
            int totalPassenger = passenger - passengersDown + passengersUp;

            for (int i = 1; i <= stopsCount; i++)
            {
                passengersDown = int.Parse(Console.ReadLine());
                passengersUp = int.Parse(Console.ReadLine());

                totalPassenger = (totalPassenger - passengersDown + passengersUp);

                if (i % 2 == 0)
                {
                    totalPassenger -= 2;

                }
                else
                {
                    totalPassenger += 2;

                }
            }

            Console.WriteLine($"The final number of passengers is : {totalPassenger}");
        }
    }
}
