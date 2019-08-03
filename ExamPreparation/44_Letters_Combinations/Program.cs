using System;

namespace _44_Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i != skip && j != skip && k != skip)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
