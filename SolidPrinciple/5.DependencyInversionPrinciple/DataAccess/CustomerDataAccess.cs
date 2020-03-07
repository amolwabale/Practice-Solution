using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.DependencyInversionPrinciple.DataAccess
{
    public class CustomerDataAccess : ICustomeDataAccess
    {
        public void Save(object objCustomer)
        {
            Console.WriteLine("Save");
        }
    }
}
