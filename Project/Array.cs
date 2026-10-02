using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal static class Array
    {
        internal static void ArrayExample()
        {
            string[] names = { "Fareed", "Ahmed", "Sultan" };
            Console.WriteLine("Array elements:");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("For Each Loops:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
