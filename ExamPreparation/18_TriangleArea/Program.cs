﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine("Area is: {0:f2}", area);
        }
    }
}
