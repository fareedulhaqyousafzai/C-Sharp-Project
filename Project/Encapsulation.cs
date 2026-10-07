using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Encapsulation
    {
        private int Id;
        private string Name;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                Console.WriteLine("Invalid ID. Please enter a positive value.");

            }
            else
            {
                this.Id = Id;
            }
        }
        public void GetId()
        {
            if (this.Id <= 0)
            {

            }
            else
            {
                Console.WriteLine("User ID is:" + this.Id);
            }
        }

        public void SetName(string Name)
        {

            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Invalid Name. Please enter a valid name.");
            }
            else
            {
                this.Name = Name;
            }
        }

        public void GetName()
        {
            if (string.IsNullOrWhiteSpace(this.Name))
            {
 
            }
            else
            {

                Console.WriteLine("User Name is:" + this.Name);
            }
        }
    }
}
