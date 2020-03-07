using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.SingleResponsibilityPrinciple.Interface
{
    public interface ICustomerOrder
    {
        void GetCustomerOrder(int CustomerId);
        void PlaceCustomerOrder(int CustomerId, string CustomerOrder);
    }
}
