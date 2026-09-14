using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{

    internal class NewFuncation
    {
        int a, b, c;

        internal void getdata()
        {
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
        }

        internal void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
        internal void sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }
        internal void mul()
        {
            c = a * b;
            Console.WriteLine(c);
        }
        internal void div()
        {
            c = b / a;
            Console.WriteLine(c);
        }
    }
}

