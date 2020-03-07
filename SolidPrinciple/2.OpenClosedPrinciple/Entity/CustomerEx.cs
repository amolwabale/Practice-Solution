using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.OpenClosedPrinciple.Entity
{
    public class CustomerEx : Customer
    {
        public string CustomerType { get; set; }

        public void SaveCustomer(string CustomerName, string Customerype)
        {
            Console.WriteLine("Customer saved - " + CustomerName);
        }

    }
}
