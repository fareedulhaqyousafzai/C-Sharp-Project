using System;

namespace Project
{
    internal static class Table
    {
        internal static void PrintTable()
        {
            Console.WriteLine("Enter Table Number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! Please type a number only.");
            }
        }
    }
}