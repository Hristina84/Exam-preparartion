using System;

namespace _32_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalLoad = 0;
            double avaragePrice = 0;
            double load1 = 0;
            double load2 = 0;
            double load3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int load = int.Parse(Console.ReadLine());

                if (load <= 3)

                {
                    load1 += load; load1 = 200 * load;
                }
                else if (load >= 4 && load <= 11)

                {
                    load2 += load; load2 = 175 * load;
                }
                else
                {
                    load3 += load; load3 = 120 * load;
                }

                totalLoad = load++;
                avaragePrice = load1 + load2 + load3;
            }

            Console.WriteLine($"{(avaragePrice / (double)totalLoad):f2}");

        }
    }
}
