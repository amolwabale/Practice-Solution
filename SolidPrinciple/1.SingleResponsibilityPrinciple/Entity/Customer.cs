using _1.SingleResponsibilityPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.SingleResponsibilityPrinciple.Entity
{
    public class Customer : ICustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public void GetCustomer(int CustomerId)
        {
            Console.WriteLine("The customer is - " + CustomerId);
        }

        public void SaveCustomer(string CustomerName)
        {
            Console.WriteLine("Customer saved - " + CustomerName);
        }

        public void UpdateCustomer(string CustomerName, int CustomerId)
        {
            Console.WriteLine("Customer updated - " + CustomerId);
        }
    }
}
