using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Project
{
    internal class Polymorphism_Static
    {
        int firstNum=10;
        int secondNum = 20;

        int thirdNum = 30;

        string name = "Fareed";
        string lastName = "Khan";
        public void Add()
        {
            int result = firstNum + secondNum;
            Console.WriteLine($"Addition of {firstNum} and {secondNum} is: {result}");
        }
        public void Add( int firstNum ,int secondNum    )
        {
            int result = firstNum + secondNum;
            Console.WriteLine($"Addition of {firstNum} and {secondNum} is: {result}");
        }
        public void Add(int firstNum, int secondNum, int thirdNum)
        {
            int result = firstNum + secondNum + thirdNum;
            Console.WriteLine($"Addition of {firstNum}, {secondNum} and {thirdNum} is: {result}");
        }
        public  void Add(string name, string lastName)
        {
            string fullName = name + " " + lastName;

        }


    }
}
