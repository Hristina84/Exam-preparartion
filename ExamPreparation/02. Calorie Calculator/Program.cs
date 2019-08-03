using System;

namespace _02.Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine();
            int weight = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string activityLevel= Console.ReadLine();


            double calories = 0;

            if (sex == "m" && activityLevel == "sedentary")

               calories = Math.Ceiling((66 + (13.7 * weight) + (5 * height * 100) - (6.8 * age)) * 1.2);

            Console.WriteLine($"To maintain your current weight you will need {calories} calories per day.");

        }
    }
}
