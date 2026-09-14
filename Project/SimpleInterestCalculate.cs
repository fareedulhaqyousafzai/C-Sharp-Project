using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Project
{
    internal class SimpleInterestCalculate
    {
        internal static void CalculateSimpleInterest()
        {
            double Principal = 1000000;
            double InterestRate = 5;
            double Tenure = 10;

            double simpleInterest = (Principal * InterestRate* Tenure) / 100;
            Console.WriteLine("Simple Interest: " + simpleInterest);
        }

    }
}
