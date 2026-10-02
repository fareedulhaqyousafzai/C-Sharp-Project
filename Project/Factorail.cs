using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal static class Factorail
    {
        internal static void CalculateFactorial()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                  
                    factorial *= i;
                 
                }
                Console.WriteLine($"Factorial of {number} is {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid Input! Please type a number only.");
            }
        }
    }
}
