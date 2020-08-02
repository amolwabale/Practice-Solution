using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.Entity
{
    class ContractEmployee : IEmployee
    {
        public void CalculateBonus()
        {
            Console.WriteLine("Calculate Bonus");
        }

        public void GetEmployeeDetails()
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeSalary()
        {
            throw new NotImplementedException();
        }

        public void getEmployeeType()
        {
            throw new NotImplementedException();
        }
    }
}
