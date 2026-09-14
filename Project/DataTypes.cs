using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class DataTypes
    {
        internal static void PrimativeDataTypes()
        {
            string name = "Fareed";
            int num = 10;
            float fnum = 10.5f;
            double dnum = 20.5;
            byte bt = 10;
            char ch = 'A';
            bool isTrue = true;

            Console.WriteLine("Primitive Data Types:");
            Console.WriteLine("String: " + name);
            Console.WriteLine("Integer: " + num );
            Console.WriteLine("Float: " + fnum);
            Console.WriteLine("Double: " + dnum);
            Console.WriteLine("Byte: " + bt);
            Console.WriteLine("Character: " + ch);
            Console.WriteLine("Boolean: " + isTrue);
        }

        internal static void derivedDataTypes()
        {
            String name = "Fareed";
            Int16 num1 = 10;
            Byte bt = 10;
            Double dnum = 20.5;
            Char ch = 'A';
            Boolean isTrue = true;
            Object obj = 10;

            Console.WriteLine("\nDerived Data Types ");
            Console.WriteLine("String: " + name);
            Console.WriteLine("Int16: " + num1);
            Console.WriteLine("Byte: " + bt);
            Console.WriteLine("Double: " + dnum);
            Console.WriteLine("Character: " + ch);
            Console.WriteLine("Boolean: " + isTrue);
            Console.WriteLine("Object: " + obj);    
        }
    }
}
