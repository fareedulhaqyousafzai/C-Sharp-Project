using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal static class Type_Conversion
    {
      
            internal static void type_conversion_fun()
            {
                Console.WriteLine("======================================");
                Console.WriteLine("     DATA TYPE CONVERSION IN C#       ");
                Console.WriteLine("======================================\n");

               
                int smallBox = 100;
                double largeBox = smallBox;
                Console.WriteLine("--- 1. Implicit Casting ---");
                Console.WriteLine($"int value: {smallBox} khud double ban gaya: {largeBox}\n");


                // 2. Explicit Casting (Bare dabbe se chota dabba - Manual)
                double decimalNumber = 99.99;
                int wholeNumber = (int)decimalNumber;
                Console.WriteLine("--- 2. Explicit Casting ---");
                Console.WriteLine($"double value: {decimalNumber} zabardasti int banaya: {wholeNumber} (.99 zaya ho gaya)\n");


                // 3. Built-in Conversion Methods (String se math numbers)
                string ageText = "24";
                int ageConvert = Convert.ToInt32(ageText);
                float ageParse = float.Parse(ageText);

                Console.WriteLine("--- 3. Conversion Methods ---");
                Console.WriteLine($"String '{ageText}' -> Convert.ToInt32 ban gaya: {ageConvert}");
                Console.WriteLine($"String '{ageText}' -> float.Parse ban gaya: {ageParse}\n");


                // 4. TryParse (Crash-Proof Professional Trick)
                Console.WriteLine("--- 4. Professional TryParse ---");
                Console.WriteLine("Apni fees darj karein (Sirf numbers mein): ");
                string userInput = Console.ReadLine();

               
                if (int.TryParse(userInput, out int fees))
                {
                    Console.WriteLine($"Zabardast! Aapki fees {fees} rupees system mein kamyabi se save ho gayi.");
                }
                else
                {
                   
                    Console.WriteLine("Ghalti! Aapne numbers ke bajaye ABC ya ghalat harf likh diya hai.");
                }
            }
        }
    }

