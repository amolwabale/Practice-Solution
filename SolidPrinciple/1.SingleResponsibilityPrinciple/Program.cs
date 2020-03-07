using _1.SingleResponsibilityPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.SingleResponsibilityPrinciple
{
    class Program
    {
        //Implement Single Responsibility for Customer and Customer Order
        static void Main(string[] args)
        {
            Customer objCustomer = new Customer();
            objCustomer.SaveCustomer("John Doe");
            CustomerOrder ObjCustomerOrder = new CustomerOrder();
            ObjCustomerOrder.PlaceCustomerOrder(1, "Iphone 10");
        }
    }
}
