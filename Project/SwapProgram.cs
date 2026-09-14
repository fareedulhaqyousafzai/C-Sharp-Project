using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class SwapProgram
    {
        static int a = 5, b = 10;

        internal static void swap()
        {
            //Console.WriteLine("Before swapping: a = " + a + ", b = " +b);
            //int temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("After swapping: a ={0} and b ={1}", a,b);

            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            a = a + b;     // a becomes 15
            b = a - b; // b becomes 5
            a = a - b; // a becomes 10
            Console.WriteLine("After swapping: a = {0} and b = {1}", a, b);


        }
    }
}
