using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class If_else
    {
        internal static void agecheck()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("Your are eligible for voting.");
            }
            else
            {
                Console.WriteLine("Your are not eligible for voting.");
            }
        }
    }
}
