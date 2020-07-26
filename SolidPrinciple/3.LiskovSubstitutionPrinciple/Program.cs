using _3.LiskovSubstitutionPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> lst = new List<IEmployee>();
            lst.Add(new PermanentEmployee());
            lst.Add(new ContractEmployee());

            Employee obj = new PermanentEmployee();
        
        }
    }
}
