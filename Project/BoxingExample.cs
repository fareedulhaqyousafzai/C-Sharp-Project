using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class BoxingExample
    {
        internal static void Boxing()
        {
            int mum = 10;
            object obj = mum; // Boxing
            Console.WriteLine("Boxing: " + obj);
        }
        internal static void UnBoxing()
        {
            object obj = 20; // Boxing
            int num = (int)obj; // Unboxing
            Console.WriteLine("UnBoxing: " + num);
        }
    }
}
