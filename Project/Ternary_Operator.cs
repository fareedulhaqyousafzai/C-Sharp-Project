using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Ternary_Operator
    {
   
        internal static void CheckAge()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            string result = (age >= 18) ? "You are Eligible for voting." : "You are not eligible for voting.";
            Console.WriteLine(result);
        }
        internal static void oddEven()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = (number % 2 == 0) ? "The number is even." : "The number is odd.";
            Console.WriteLine(result);
        }
        internal static void loopyear()
        {
            int year = 1000;
        string result = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "The year is a leap year." : "The year is not a leap year.";
            Console.WriteLine(result);
        }
        internal static void NumberDivisibleBy3And5()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = (number % 3 == 0 && number % 5 == 0) ? "The number is divisible by both 3 and 5." : "The number is not divisible by both 3 and 5.";
            Console.WriteLine(result);
        }
    }
}
