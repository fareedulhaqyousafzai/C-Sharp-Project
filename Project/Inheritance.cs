using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Inheritance
    {

        public class Employee {

            public string EmpName;
            public int Empid;


        }
        public class PermanentEmployee : Employee {

            public int PermanentEmpSalary;
        }

        public class ContractEmployee:Employee
        {

          public  int ContractEmpSalary;
        }
    }
}
