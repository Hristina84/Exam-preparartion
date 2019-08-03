using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int peopleInCar = 0;
            int peopleInBus = 0;
            int peopleInLittleBus = 0;
            int peopleInBigBus = 0;
            int peopleInTrain = 0;
            int totalPeople = 0;

            for (int i = 1; i <= n; i++)
            {
                int PeopleInGroup = int.Parse(Console.ReadLine());

                if (PeopleInGroup <= 5)

                { peopleInCar += PeopleInGroup; }

                else if (PeopleInGroup >= 6 && PeopleInGroup <= 12)

                { peopleInBus += PeopleInGroup; }

                else if (PeopleInGroup > 12 && PeopleInGroup <= 25)

                { peopleInLittleBus += PeopleInGroup; }

                else if (PeopleInGroup >= 26 && PeopleInGroup <= 40)

                { peopleInBigBus += PeopleInGroup; }

                else

                { peopleInTrain += PeopleInGroup; }

                totalPeople = peopleInCar + peopleInBus + peopleInLittleBus + peopleInBigBus + peopleInTrain;
            }
            
                

                Console.WriteLine($"{((double)peopleInCar / (double)totalPeople) * 100:f2}%");
                Console.WriteLine($"{((double)peopleInBus / (double)totalPeople) * 100:f2}%");
                Console.WriteLine($"{((double)peopleInLittleBus / (double)totalPeople) * 100:f2}%");
                Console.WriteLine($"{((double)peopleInBigBus / (double)totalPeople) * 100:f2}%");
                Console.WriteLine($"{((double)peopleInTrain / (double)totalPeople) * 100:f2}%");
            
            
        }
    }
}
