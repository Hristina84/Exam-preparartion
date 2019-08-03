using System;

namespace _40_Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritMoney = double.Parse(Console.ReadLine());
            int yearLiving = int.Parse(Console.ReadLine());

            int moneySpend = 0;

            for (int i = 1800; i <= yearLiving; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpend = 12000;
                }
                if (i % 2 != 0)
                {
                    moneySpend = 12000 + 50 * (yearLiving - 1800 + 18);
                }
            }
            double totalMoney = (yearLiving - 1800) * moneySpend;

            if (totalMoney <= inheritMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritMoney - totalMoney } dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need { totalMoney - inheritMoney }dollars to survive.");
            }
        }
    }
}
