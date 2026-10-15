using System;

namespace Project
{
   
    interface IEmployeee
    {
        void Show();
    }

    interface IPerson
    {
        void Show();
    }

    class PartTimeEmployeee : IEmployeee, IPerson
    {
      
        void IEmployeee.Show()
        {
            Console.WriteLine("This is IEmployee's Show method!");
        }

 
        void IPerson.Show()
        {
            Console.WriteLine("This is IPerson's Show method!");
        }
    }
}