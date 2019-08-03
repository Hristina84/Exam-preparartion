using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_RadiansTo_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var degrees =Math.Round(((180* rad)/ Math.PI), 0);
            
            Console.WriteLine("degrees= {0}", degrees);


        }
    }
}
