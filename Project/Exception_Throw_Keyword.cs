using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Exception_Throw_Keyword
    {

        public static void run()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("Your are eligible for voting.");
                }
                else
                {
                    throw new Exception("Your are not eligible for voting.");


                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void show()
        {
            int account_balance = 5000;
            Console.WriteLine("Account Balance is: " + account_balance);
            Console.WriteLine("Enter Amount:");

            try
            {
                int withdrawal_amount = Convert.ToInt32(Console.ReadLine());


           
                if (withdrawal_amount <= 0)
                {
                    throw new Exception("Amount cannot be Zero or Negative!!");
                }
                if (withdrawal_amount < 500)
                {
                    throw new Exception("Minimum withdrawal amount is 500 Rs!!");
                }
                if (withdrawal_amount % 500 != 0)
                {
                    throw new Exception("Please enter amount in multiples of 500 (e.g. 500, 1000, 1500)!!");
                }

                if (account_balance < withdrawal_amount)
                {
                    throw new Exception("Insufficient Balance!!");
                }

               
                account_balance = account_balance - withdrawal_amount;

                Console.WriteLine("Remaining Balance is: " + account_balance);
                Console.WriteLine("Transaction completed successfully!!!");
            }
            catch (Exception Ex)
            {
              
                Console.WriteLine("Error: " +Ex.Message);
            }


        }
    }
}
