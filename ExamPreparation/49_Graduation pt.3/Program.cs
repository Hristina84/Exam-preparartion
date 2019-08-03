using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Graduation_pt._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double averageGrade = 0;
            double Sum = 0;

            while (name != "END")
            {

                for (int i = 1; i <= 12; i++)
                {
                    double average = double.Parse(Console.ReadLine());
                    int count = 0;

                    if (average >= 4)
                    {
                        Sum += average;
                        averageGrade = Sum / 12;                        
                    }
                    else
                    {
                        count++;
                        if (count >= 2)
                        {
                            Console.WriteLine($"{name} has been excluded at {count} grade"); break;
                        }

                    }
                    
                }
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");

                name = Console.ReadLine();
            }
        }
    }
}
