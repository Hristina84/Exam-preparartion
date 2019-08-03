using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());

            double totalPrice = 0;
            double sushiPrice = 0;
            double price = 0;

            if (restaurantName == "Sushi Zone")
            {                
                switch (sushiType)
                {
                    case "sashimi":
                        sushiPrice = 4.99; break;
                    case "maki":
                        sushiPrice = 5.29; break;
                    case "uramaki":
                        sushiPrice = 5.99; break;
                    case "temaki":
                        sushiPrice = 4.29; break;
                }                             
                
            }
            else if (restaurantName == "Sushi Time")
            {
                switch (sushiType)
                {
                    case "sashimi":
                        sushiPrice = 5.49; break;
                    case "maki":
                        sushiPrice = 4.69; break;
                    case "uramaki":
                        sushiPrice = 4.49; break;
                    case "temaki":
                        sushiPrice = 5.19; break;
                }
            }
            else if (restaurantName == "Sushi Bar")
            {
                switch (sushiType)
                {
                    case "sashimi":
                        sushiPrice = 5.25; break;
                    case "maki":
                        sushiPrice = 5.55; break;
                    case "uramaki":
                        sushiPrice = 6.25; break;
                    case "temaki":
                        sushiPrice = 4.75; break;
                }
            }
            else if (restaurantName == "Asian Pub")
            {
                switch (sushiType)
                {
                    case "sashimi":
                        sushiPrice = 4.50; break;
                    case "maki":
                        sushiPrice = 4.80; break;
                    case "uramaki":
                        sushiPrice = 5.50; break;
                    case "temaki":
                        sushiPrice = 5.50; break;
                }
            }
            else
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!"); return;
            }

            price = portions * sushiPrice;

            if (order == 'Y')
            {
                totalPrice = price + 0.2 * price;
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }

            else if (order == 'N')
            {
                Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
            }
        }
    }
}
