using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
   

        abstract class Person
        {
            public string firstName;
            public string lastName;

           public  string phoneNumber;

           public int age;

            public abstract void showDetails();


        }
        class student : Person
        {
            public int rollNumber;
            public int fees;

            public override void  showDetails()
            {
                string name = this.firstName + " " + this.lastName;
                Console.WriteLine("Student Name is :{0}",name);
                Console.WriteLine("Student Phone Number is :{0}",phoneNumber);
                Console.WriteLine("Student Age is :{0}",age);
                Console.WriteLine("Student Roll Number is :{0}", rollNumber);
                Console.WriteLine("Student Fees is :{0}", fees);

            }

        }
        class teacher:Person
        {
           public string qualification;
           public int salary;
            public override void showDetails()
            {
                string name = this.firstName + " " + this.lastName;
                Console.WriteLine("Teacher Name is :{0}", name);
                Console.WriteLine("Teacher  Phone Number is :{0}", phoneNumber);
                Console.WriteLine("Teacher  Age is :{0}", age);
                Console.WriteLine("Teacher  Qualification is :{0}", qualification);
                Console.WriteLine("Teacher  Salary is :{0}", salary);

            }
        }
    }

