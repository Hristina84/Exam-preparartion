using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double astronautHeight = double.Parse(Console.ReadLine());

            double spacecraftVolume = width * length * height;

            double roomVolume = (astronautHeight + 0.40) * 2 * 2;

            double totalAstronautsPlace = spacecraftVolume / roomVolume;

            if (totalAstronautsPlace >= 3 && totalAstronautsPlace <= 10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(totalAstronautsPlace)} astronauts.");
            }

            else if (totalAstronautsPlace < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }

            else if (totalAstronautsPlace > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
