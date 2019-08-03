using System;

namespace _04_Charity_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int confectionerCount = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int waferCount = int.Parse(Console.ReadLine());
            int pancakeCount = int.Parse(Console.ReadLine());

            double totalAmountPerDay = (((double)cakeCount * 45) + ((double)waferCount * 5.80) + ((double)pancakeCount * 3.20)) * (double)confectionerCount;
            double totalAmount = (double)totalAmountPerDay * daysCount;
            double profit = ((double)totalAmount - ((double)totalAmount / 8));

            Console.WriteLine(" {0:F2}", profit);
        }
    }
    }
