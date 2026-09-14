using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Digit_Number_Reverse
    {
        internal static void ReverseNumber()
        {
            int num = 123;

            int d1 = num % 10;    
            int num2 = num / 10;  

            int d2 = num2 % 10;    
            int d3 = num2 / 10;    

           
            int reverse = (d1 * 100) + (d2 * 10) + d3;

            Console.WriteLine("Reverse Number: " + reverse);
        }
    }
}
