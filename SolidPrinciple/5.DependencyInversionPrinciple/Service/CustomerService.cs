using _5.DependencyInversionPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.DependencyInversionPrinciple.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Save(object objCustomer)
        {
            _customerRepository.SaveToDb(objCustomer);
        }
    }
}
