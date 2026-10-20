using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Project
{
    internal static class Exception_Handling
    {
        public static void Run()
        {
            Console.WriteLine("Enter Your First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your secound Number");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("division is :" + result);

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You con not divide by zero.....");
            }
            Console.WriteLine("Remaining statement 1");
            Console.WriteLine("Remaining statement 2");
            Console.WriteLine("Remaining statement 3");
        }
        public static void print()
        {
            try
            {
                int[] arr = new int[3];
                arr[0] = 10;
                arr[1] = 20;
                arr[2] = 30;
                arr[3] = 50;

                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array Range is Exceeded");
            }
            
         


        }
    }
}
