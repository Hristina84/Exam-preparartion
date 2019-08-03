using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            string piecesCount = Console.ReadLine();
            int totalPieces = width * lenght;
          
            while (piecesCount != "STOP")
            {
                int piecesTook = int.Parse(piecesCount);
                totalPieces -= piecesTook;
             
                if (totalPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    return;
                }
                piecesCount = Console.ReadLine();
            }
            Console.WriteLine($"{totalPieces} pieces are left.");

        }
    }
}
