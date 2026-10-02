using System;

namespace Project
{
    internal static class Loops
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


        internal static void WhileLoop()
        {
            int number = 123456789;

            while (number > 0)
            {
                Console.WriteLine(number);
                number /= 10;

            }
        }
        internal static void WhileLoops()
        {
            int number = 123456789;
            string str = "";

            while (number != 0)
            {
                str += number % 10;
                number /= 10;

            }
            Console.WriteLine("revers is: " + str);


        }

        internal static void DoWhileLoop()
        {
            int num = 1;

            do
            {
                Console.WriteLine("PAKISTAN");
                num++;
            }
            while (num < 10);
            Console.WriteLine("welcome");
        }

        internal static void NestedLoops()
        {
          
            for (int i = 1; i <= 5; i++)
            {
               
                for (int j = 1; j <= 6-i; j++)
                {
                    if(i % 2 != 0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(6-j);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

