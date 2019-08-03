using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
