using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class If_else_If
    {
        internal static void PercentageCalculator()
        {
            Console.WriteLine("Enter your Percentage:");
            string input = Console.ReadLine();
            int percentage;

            if (int.TryParse(input, out percentage))
            {
                if (percentage >= 0 && percentage < 40)
                {
                    Console.WriteLine("You are Fail");
                }
                else if (percentage >= 40 && percentage < 50)
                {
                    Console.WriteLine("Grade D");
                }
                else if (percentage >= 50 && percentage < 60)
                {
                    Console.WriteLine("Grade C");
                }
                else if (percentage >= 60 && percentage < 70)
                {
                    Console.WriteLine("Grade B");
                }
                else if (percentage >= 70 && percentage < 80)
                {
                    Console.WriteLine("Grade A");
                }
                else if (percentage >= 80 && percentage < 90)
                {
                    Console.WriteLine("Grade A+");
                }
                else if (percentage >= 90 && percentage <= 100)
                {
                    Console.WriteLine("Grade A++");
                }
                else
                {
                    Console.WriteLine("Invalid Percentage Number");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! Please type numbers only.");
            }
        }
    }
}