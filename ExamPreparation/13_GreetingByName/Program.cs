﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_GreetingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr your name: "); 
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}! ",name);
        }
    }
}
