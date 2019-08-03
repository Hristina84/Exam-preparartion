using System;

namespace _33_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int count200 = 0;
            int count100 = 0;
            int count50 = 0;
            int count20 = 0;
            int count10 = 0;
            int count5 = 0;
            int count2 = 0;
            int count1 = 0;
            int countCoins = 0;

            while (n != 0)
            {
                int n1 = (int)n * 100;
                count200 = n1 / 200;
                int a = count200 % 200;

                count100 = a / 100;
                int b = count100 % 100;

                count50 = b / 50;
                int c = count50 % 50;

                count20 = c / 20;
                int d = count20 % 20;

                count10 = d / 10;
                int e = count50 % 10;

                count5 = e / 5;
                int f = count50 % 5;

                count2 = f / 2;
                int g = count50 % 2;

                count1 = g;

                n = double.Parse(Console.ReadLine());
            }

            countCoins = count200 + count100 + count50 + count20 + count10 + count5 + count2 + count1;
            Console.WriteLine(countCoins);
        }
    }
}
