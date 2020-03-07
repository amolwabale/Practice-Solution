using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.DependencyInversionPrinciple.Service
{
    public interface ICustomerService
    {
        void Save(object objCustomer);
    }
}
