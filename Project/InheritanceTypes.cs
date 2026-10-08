using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class InheritanceTypes
    {
        public class BaseClass
        {
            public void Show()
            {
                Console.WriteLine("this is Base class method");
            }

            
        }

        public class DerivedClass:BaseClass
        {
            public void show2()
            {

                Console.WriteLine("this is a methods of Derived Class.... ");
            }
        }

        public class NewEmployee
        {

            public string EmpName;
            public int Empid;


        }
        public class NewPermanentEmployee : NewEmployee
        {

            public int PermanentEmpSalary;
        }

        public class NewContractEmployee : NewEmployee
        {

            public int ContractEmpSalary;
        }


        public class Person
        {
            public string Name;
            public void Eat()
            {
                Console.WriteLine("Person is eating lunch.");
            }
        }
        public class Employee : Person
        {
            public int EmployeeId;
            public void Work()
            {
                Console.WriteLine("Employee is working on a project.");
            }
        }
        public class Manager : Employee
        {
            public string DepartmentName;
            public void ManageTeam()
            {
                Console.WriteLine("Manager is managing the team.");
            }
        }
    }
}
