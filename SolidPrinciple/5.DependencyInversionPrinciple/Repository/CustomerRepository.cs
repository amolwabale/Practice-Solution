using _5.DependencyInversionPrinciple.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.DependencyInversionPrinciple.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private ICustomeDataAccess _customeDataAccess;
        public CustomerRepository()
        {
            _customeDataAccess = new CustomerDataAccess();
        }
        public void SaveToDb(object objCustomer)
        {
            _customeDataAccess.Save(objCustomer);
        }
    }
}
