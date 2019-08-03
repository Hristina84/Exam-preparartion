using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hours = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double pricePerPerson = 0;
            double price = 0;
            double totalPrice = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (time == "day")
                { price = 10.50; pricePerPerson += price; }
                else
                { price = 8.40; pricePerPerson += price; }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (time == "day")
                { price = 12.60; pricePerPerson += price; }
                else
                { price = 10.20; pricePerPerson += price; }
            }
            totalPrice = (pricePerPerson * people )* hours;

            if (people >= 4)
            {
                pricePerPerson = price - price * 0.1;
                
            }
            else if (hours >= 5 )
            {
                totalPrice = pricePerPerson - pricePerPerson * 0.5;                
            }
            Console.WriteLine($"Price per person for one hour: {pricePerPerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");
        }
    }
}
