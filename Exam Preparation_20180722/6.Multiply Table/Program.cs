using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstNum = num / 100;
            int secondNum =( num / 10)% 10;
            int thirdNum = num % 10;

            for (int i = 1; i <= thirdNum; i++)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    for (int k = 1; k <= firstNum; k++)
                    {
                        if (i > 0 && j >0 && k >0)
                        {
                            Console.WriteLine($"{i} * {j} * {k} = {i*j*k};");
                        }
                    }
                }
            }
        }
    }
}
