using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double priceRakia = 0.5 * priceWhiskey;
            double priceWine = priceRakia- (0.4 * priceRakia);
            double priceBeer = priceRakia- (0.8 * priceRakia);

            double totalPrice = (priceWhiskey * whiskeyQuantity) + (priceRakia * rakiaQuantity) + (priceBeer * beerQuantity) + (priceWine * wineQuantity);

            Console.WriteLine(" {0:F2}", totalPrice);
        }
    }
    }

