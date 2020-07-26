using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.Entity
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public void CalculateBonus()
        {
            Console.WriteLine("Bonus");
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Employee Details");
        }

        public void GetEmployeeSalary()
        {
            Console.WriteLine("Salary");
        }

        public void getEmployeeType()
        {
            Console.WriteLine("Employee Type");
        }
    }
}
