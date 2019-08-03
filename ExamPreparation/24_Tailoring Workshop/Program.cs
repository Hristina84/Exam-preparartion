using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tableCount = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double coverArea =tableCount* (tableWidth + 2 * 0.30) * (tableLenght + 2 * 0.3);
            double squareArea = tableCount * (tableLenght / 2) * (tableLenght / 2);


            double priceUSD = coverArea*7 + squareArea*9 ;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine("{0:F2} USD", priceUSD);
            Console.WriteLine("{0:F2} BGN", priceBGN);


        }
    }
}
