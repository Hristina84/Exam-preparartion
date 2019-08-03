using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inches=");
            double inches =double.Parse(Console.ReadLine());
            double centimeters = 2.54 * inches;
            Console.WriteLine("centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
