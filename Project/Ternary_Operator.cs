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
    }
}
