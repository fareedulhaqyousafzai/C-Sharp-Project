using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Unary_Operators
    {
     internal static void PostIncrement()
        {
            int a = 10;
            int b = a++ + a++ + a++;

            Console.WriteLine("PostIncrement");
            Console.WriteLine($"Value of a: {a}"); 
            Console.WriteLine($"Value of b: {b}"); 
        }
        internal static void PreIncrement()
        {
            int a = 10;
            int b = ++a + ++a + ++a;
            Console.WriteLine("PreIncrement");
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");
        }
        internal static void PostDecrement()
        {
            int a = 10;
            int b = a-- + a-- + a--;

            Console.WriteLine("PostDecrement");
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");
        }
        internal static void PreDecrement()
        {
            int a = 10;
            int b = --a + --a + --a;
            Console.WriteLine("PreDecrement");
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");
        }
    }
}
