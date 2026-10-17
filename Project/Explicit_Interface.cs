using System;

namespace Project
{
   
    interface IEmployeee
    {
        void Show();
    }

    interface IPersonn
    {
        void Show();
    }

    class PartTimeEmployeee : IEmployeee, IPersonn
    {
      
        void IEmployeee.Show()
        {
            Console.WriteLine("This is IEmployee's Show method!");
        }

 
        void IPersonn.Show()
        {
            Console.WriteLine("This is IPerson's Show method!");
        }
    }
}