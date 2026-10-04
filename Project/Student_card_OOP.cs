using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Student_card_OOP
    {
        string name;
        int rollNumber;
        internal void getdata()
        {
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Roll Number:");
            rollNumber = Convert.ToInt32(Console.ReadLine());
        }
        internal void displaydata()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Roll Number: " + rollNumber);
        }
    }
}
