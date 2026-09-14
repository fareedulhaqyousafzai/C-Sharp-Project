using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Circle_TriangleCalculate
    {
        internal static void CalculateCircleArea()
        {
            double radius = 5;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
