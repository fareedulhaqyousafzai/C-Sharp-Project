using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Constructor
    {

        string studentname;
        int studentid;
        //public Constructor()
        //{
        //    Console.WriteLine("Constructor called");
        //}

        public Constructor(string name, int id)
        {
            this.studentname = name;
            this. studentid = id;
        }

        public void ShowData()
        {
            Console.WriteLine($"Student Name: {this.studentname}, ID: {this.studentid}");
        }



    }
}
