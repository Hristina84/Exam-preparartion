using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Element_equal_to_other_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            
            var max = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }                     

                if (max == (sum - max))
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {sum + max}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs( max-(sum - max))}");
                }
            }
        }
    }

