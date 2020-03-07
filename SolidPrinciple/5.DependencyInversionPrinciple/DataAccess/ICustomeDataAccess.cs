using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.DependencyInversionPrinciple.DataAccess
{
    public interface ICustomeDataAccess
    {
        void Save(object objCustomer);
    }
}
