
using _2.OpenClosedPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.OpenClosedPrinciple.Entity
{
    public class CustomerOrder : ICustomerOrder
    {
        public void GetCustomerOrder(int CustomerId)
        {
            Console.WriteLine("The customer order is - " + CustomerId);
        }

        public void PlaceCustomerOrder(int CustomerId, string CustomerOrder)
        {
            Console.WriteLine("Placing customer order - " + CustomerOrder);
        }
    }
}
