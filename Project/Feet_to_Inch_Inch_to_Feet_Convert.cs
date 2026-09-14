using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Feet_to_Inch_Inch_to_Feet_Convert
    {
        internal static void ConvertFeetToInches()
        {
            double feet = 5;
            double inches = feet * 12;
            Console.WriteLine(feet + " feet is equal to " + inches + " inches.");

            double totalInches = 60;
            double totalFeet = totalInches / 12;
            Console.WriteLine(totalInches + " inches is equal to  = " + totalFeet + " feet");
        }
    }
}
