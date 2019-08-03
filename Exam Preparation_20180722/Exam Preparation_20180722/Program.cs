using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_20180722
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyFood = double.Parse(Console.ReadLine());
            double moneySouvenirs = double.Parse(Console.ReadLine());
            double moneyHotel = double.Parse(Console.ReadLine());

            double moneyOil = (420*((double)7 / 100 )) * 1.85;

            double dailyMoney = 3 * moneyFood + 3 * moneySouvenirs;

            double totalHotel = moneyHotel * (0.9 + 0.85 + 0.8);

            double totalMoney = moneyOil + dailyMoney + totalHotel;

            Console.WriteLine($"Money needed: {totalMoney :f2}");

        }
    }
}
