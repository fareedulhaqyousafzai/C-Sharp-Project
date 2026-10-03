using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Student_card_OOP
    {
        string name;
        int rollNumber;
        string studentClass;
      
      

        internal void getdata()
        {
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Roll Number:");
            rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Class:");
            studentClass  = Console.ReadLine();
            Console.WriteLine("Enter Student Section:");
         
        }
        internal void displaydata()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Roll Number: " + rollNumber);
            Console.WriteLine("Student Class: " + studentClass);
        }
    }
}
