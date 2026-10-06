using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Constructor
    {

        string studentname;
        int studentid;
        int age;
        public Constructor()
        {
            Console.WriteLine("Default Constructor");
        }

        public Constructor(string name, int id)
        {
            this.studentname = name;
            this.studentid = id;
        }
        public Constructor(string name, int id, int age)
        {
            this.studentname = name;
            this.studentid = id;
            this.age = age;
        }

        public Constructor(Constructor Copy)
        {
            this.studentname = Copy.studentname;
            this.studentid = Copy.studentid;
            this.age = Copy.age;
        }
        public void ShowData()
        {
            Console.WriteLine($"Student Name: {this.studentname}, ID: {this.studentid}, Age: {this.age}");
        }

        internal class Example { 

           public static int a;

         private Example()
            {
                Console.WriteLine("Private Constructor");
            }
            
            public static void GetTime()
            {
                Console.WriteLine(DateTime.Now);
            }

            public static int Incerement()
            {
               return ++a;            
            }
        } 


    }
   

}
