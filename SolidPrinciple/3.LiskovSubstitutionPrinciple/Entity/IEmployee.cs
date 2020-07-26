using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.Entity
{
    public interface IEmployee
    {
        void GetEmployeeDetails();
        void GetEmployeeSalary();
        void getEmployeeType();
    }
}
