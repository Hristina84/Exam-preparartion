using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Pipes_in_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            int percentP1 = 0;
            int percentP2 = 0;
            int percentV = 0;
            int poolOverflow = 0;
            double realVolumeQuantity = H * (double)P1 + H * (double)P2;

            if (realVolumeQuantity == V)
            {
                percentV = 100;
                percentP1 = ((P1 * 100) / (int)realVolumeQuantity);
                percentP2 = ((P2 * 100) / (int)realVolumeQuantity);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentV, percentP1, percentP2);
            }

            else if (realVolumeQuantity < V)
            {
                percentV = ((V * 100) / (int)realVolumeQuantity);
                percentP1 = ((P1 * 100) / (int)realVolumeQuantity);
                percentP2 = ((P2 * 100) / (int)realVolumeQuantity);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentV, percentP1, percentP2);
            }

            else if (realVolumeQuantity > V)
            {
                poolOverflow = (int)realVolumeQuantity - V;

                Console.WriteLine($"For 2.5 hours the pool overflows with {0} liters.");
            }


        }
    }
}
