using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Switch
    {
        internal static void AlphabetBook()
        {
            Console.WriteLine("Enter your Alphabet:");
            string input = Console.ReadLine();
            char alphabet;
            if (char.TryParse(input, out alphabet))
            {

                alphabet = char.ToUpper(alphabet);
                switch (alphabet)
                {
                    case 'A':
                        Console.WriteLine("Apple");
                        break;
                    case 'B':
                        Console.WriteLine("Ball");
                        break;
                    case 'C':
                        Console.WriteLine("Cat");
                        break;
                    case 'D':
                        Console.WriteLine("Dog");
                        break;
                    case 'E':
                        Console.WriteLine("Elephant");
                        break;
                    case 'F':
                        Console.WriteLine("Fish");
                        break;
                    case 'G': 
                        Console.WriteLine("Goat");
                        break;
                    case 'H':
                        Console.WriteLine("Horse");
                        break;
                    case 'I':
                        Console.WriteLine("Ice Cream");
                        break;
                    case 'J':
                        Console.WriteLine("Jug");
                        break;
                    case 'K':
                        Console.WriteLine("Kite");
                        break;
                    case 'L':
                        Console.WriteLine("Lion");
                        break;
                    case 'M':
                        Console.WriteLine("Monkey");
                        break;
                    case 'N':
                        Console.WriteLine("Nest");
                        break;
                     case 'O':
                        Console.WriteLine("Orange");
                        break;
                    case 'P':
                        Console.WriteLine("Parrot");
                        break;
                    case 'Q':
                        Console.WriteLine("Queen");
                        break;
                    case 'R':

                        Console.WriteLine("Rabbit");
                        break;
                    case 'S':
                        Console.WriteLine("Snake");
                        break;
                    case 'T':
                        Console.WriteLine("Tiger");
                        break;
                    case 'U':
                        Console.WriteLine("Umbrella");
                        break;
                    case 'V':
                        Console.WriteLine("Van");
                        break;
                    case 'W':
                        Console.WriteLine("Watch");
                        break;
                    case 'X':
                        Console.WriteLine("Xylophone");
                        break;
                    case 'Y':
                        Console.WriteLine("Yak");
                        break;
                    case 'Z':
                        Console.WriteLine("Zebra");
                        break;
                    default:
                        Console.WriteLine("Invalid Alphabet");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! Please type a single alphabet.");
            }
        }
    }
}
