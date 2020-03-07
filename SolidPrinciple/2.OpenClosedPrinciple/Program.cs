using _2.OpenClosedPrinciple.Entity;
using _2.OpenClosedPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.OpenClosedPrinciple
{
    class Program
    {
        //Implement Open Closed Principle
        //With comparison to first project save customer with respect to customer type
        static void Main(string[] args)
        {
            CustomerEx objCustomer = new CustomerEx();
            objCustomer.SaveCustomer("John Doe","Temporary");
            CustomerOrder ObjCustomerOrder = new CustomerOrder();
            ObjCustomerOrder.PlaceCustomerOrder(1, "Iphone 10");
        }
    }
}
