using System;

namespace Project
{
    internal static class Loop
    {
        internal static void ForLoop()
        {
            Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();
            int checkNumber; 

            if (int.TryParse(Name, out checkNumber))
            {
               
                Console.WriteLine("Invalid Input! Name cannot be a number.");
            }
            else
            {
              
                Console.WriteLine("How many times to print?:");
                string timesInput = Console.ReadLine();
                int PrintTimes;

             
                if (int.TryParse(timesInput, out PrintTimes))
                {
                    for (int i = 1; i <= PrintTimes; i++)
                    {
                        Console.WriteLine($"{i} - Your Name is: {Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please type a number for counting.");
                }
            }
        }
    }
}