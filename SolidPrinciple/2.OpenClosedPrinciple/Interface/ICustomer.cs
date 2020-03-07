using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.OpenClosedPrinciple.Interface
{
    public interface ICustomer
    {
        void GetCustomer(int CustomerId);
        void SaveCustomer(string CustomerId);
        void UpdateCustomer(string CustomerName, int CustomerId);
    }
}
