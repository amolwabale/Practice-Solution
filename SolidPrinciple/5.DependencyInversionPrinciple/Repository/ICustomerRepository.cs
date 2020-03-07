using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.DependencyInversionPrinciple.Repository
{
    public interface ICustomerRepository
    {
        void SaveToDb(object objCustomer);
    }
}
