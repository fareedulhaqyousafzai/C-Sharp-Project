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

        public static void display()
        {

            Console.WriteLine("Enter a Number");
            string number = Console.ReadLine();

            try
            {
                int num =int.Parse(number);
                Console.WriteLine("number is :"+num);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("String format is Invaild.....");
            }
        
        }

        //public static void show()
        //{

        //    try
        //    {

        //        string name =null;
        //        Console.WriteLine(name.Length);
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        Console.WriteLine("Name is Null....");
        //    }

        //}

        public static void show()
        {

            try
            {

                //string name = null;
                //Console.WriteLine(name.Length);


                //int[] arr = new int[3];
                // arr[0] = 10;
                // arr[1] = 20;
                // arr[2] = 30;
                // arr[3] = 50;

                string name = "fareed";
                int number = int.Parse(name);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void RunMul()
        {
           
            try
            {
                Console.WriteLine("Enter Your First Number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Second Number");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("division is :" + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Math Error: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input Error: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is Executed!!!");
            }
        }
    }



    }
    
