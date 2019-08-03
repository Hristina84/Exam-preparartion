using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overTimeWorkers = int.Parse(Console.ReadLine());

            var workHours = (days-days * 0.10) *8;
            var overtimeHours = overTimeWorkers * 2 * days;
            var totalHours = Math.Truncate(workHours + overtimeHours);

            if (totalHours >= hours)

                Console.WriteLine($"Yes!{totalHours - hours} hours left." );

            else

                Console.WriteLine($"Not enough time!{hours - totalHours} hours needed.");
        }
    }
}
