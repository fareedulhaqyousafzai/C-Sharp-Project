using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
  public class StudentNew
    {
        string _name;
        int _age;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Student Name cannot be empty");
                }
                else
                {
                    _name = value;
                }


            }

        }

        public int age
        {
            get {

                return _age;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Student ID cannot be negative.");
                }
                else
                {
                    _age = value;
                }
            }
        }

 

    }

  
}
