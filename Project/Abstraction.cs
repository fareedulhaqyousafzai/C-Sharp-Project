using System;

namespace Project
{
    public class Employeee
    {
        public int EmpId;
        public string EmpName;
        public int EmpGrossSalary;

  
        public double EmpNetSalary;
        private double EmpTaxDeduction = 0.1;

        public Employeee(int Empid, string Empname, int EmpgrossSalary)
        {
            this.EmpId = Empid;
            this.EmpName = Empname;
            this.EmpGrossSalary = EmpgrossSalary;
        }

  
        private void CalculateSalary()
        {
            if (EmpGrossSalary >= 40000)
            {
                EmpNetSalary = EmpGrossSalary - (EmpTaxDeduction * EmpGrossSalary);
                Console.WriteLine($"Net Salary (After 10% Tax): {EmpNetSalary}");
            }
            else
            {
                EmpNetSalary = EmpGrossSalary; 
                Console.WriteLine($"Net Salary (No Tax): {EmpNetSalary}");
            }
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine($"--- Details of Employee: {EmpName} ---");
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Gross Salary: {EmpGrossSalary}");


            this.CalculateSalary();
            Console.WriteLine("--------------------------------------\n");
        }
    }
}