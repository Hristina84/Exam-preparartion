using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());


                if (num < 200)

                    ++p1;
                else
                    ++p2;
            }
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
