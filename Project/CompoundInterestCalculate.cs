using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class CompoundInterestCalculate
    {
        internal static void CalculateInterestCompound()
        {
            double Principal = 1000000;
            double InterestRate = 5;
            double Tenure = 10;
            double compoundInterest = Principal * Math.Pow((1 + InterestRate / 100), Tenure) - Principal;
            Console.WriteLine("Compound Interest: " + compoundInterest);
        }
    }
}
