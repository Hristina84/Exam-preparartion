using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = Math.Round((USD * 1.79549), 2);
            Console.WriteLine("BGN= {0}", BGN);
        }
    }
}
