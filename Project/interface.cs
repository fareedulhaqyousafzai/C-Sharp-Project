using System;

namespace Project
{
    interface IEmployee
    {
 
        void Show();
    }

    class PartTimeEmpolyee:IEmployee
    {
       
        public void Show()
        {
            Console.WriteLine("This is a Method of IEmployee interface !!");
        }
    }
}