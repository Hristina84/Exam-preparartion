using System;

namespace _37_Special_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            int upperTens = int.Parse(Console.ReadLine());
            int upperEntity = int.Parse(Console.ReadLine());

            for (int i = 2; i <= upperLimit; i++)
            {
                for (int j = 2; j <= upperTens; j++)
                {
                    for (int k = 2; k <= upperEntity; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
