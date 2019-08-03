using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Running_In_The_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            double totalCalories = 0;
            double totalDistance = 0;
            int totalMinutes = 0;

            for (int i = 1; i <= n; i++)
            {
                int time = int.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                string measurement = Console.ReadLine();

                if (measurement == "m")
                {                    
                    distance = distance / 1000;
                }
             
                totalCalories += time * 20;
                totalDistance += distance;
                totalMinutes += time;
            }
            Console.WriteLine($"He ran {totalDistance:f2}km for {totalMinutes} minutes and burned {totalCalories} calories.");
        }
    }
}
