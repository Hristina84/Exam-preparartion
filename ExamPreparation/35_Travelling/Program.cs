using System;

namespace _35_Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            int minBudget = int.Parse(Console.ReadLine());

            int savedMoney = 0;

            while (destination != "End")
            {

                int money = int.Parse(Console.ReadLine());


                while (savedMoney < minBudget)
                {
                    for (int i = 0; i <= minBudget; i++)

                        savedMoney += money;
                }

                /*for (int i = 0; i <= minBudget; i++)
                {

                    moneyLeft += money;

                    if (moneyLeft >= minBudget)
                    {
                        Console.WriteLine($"Going to {destination}!"); break;
                    }

                }*/

                destination = Console.ReadLine();
            }

        }
    }
}
