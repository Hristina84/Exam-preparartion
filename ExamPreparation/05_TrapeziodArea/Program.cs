using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double b1 = Double.Parse(Console.ReadLine());
            double b2 = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());
            double area = (b1 + b2) * h / 2.0;
            Console.WriteLine(area);
        }
    }
}