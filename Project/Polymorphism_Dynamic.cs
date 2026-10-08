using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Polymorphism_Dynamic
    {

        public class Parent
        {
            public virtual void Print()
            {
                Console.WriteLine("This is Parent Method");
            }
        }

        public class Child : Parent
        {
   
            public override void Print()
            {
                Console.WriteLine("This is Child Method");
            }
        }


        public class Par
        {
            public  void Print()
            {
                Console.WriteLine("This is Parent Method");
            }
        }

        public class Chil : Par
        {

            public new void Print()
            {
                Console.WriteLine("This is Child Method (Hiding Parent)");
            }
        }

        }
}
