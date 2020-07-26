using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.Entity
{
    class PermanentEmployee : Employee
    {
        public void GetEmployeeHistory()
        {
            Console.WriteLine("Employee History");
        }
    }
}
