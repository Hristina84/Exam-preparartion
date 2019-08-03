using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius. r = ");
            double r  = Double.Parse(Console.ReadLine());
            double area = Math.PI* r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
