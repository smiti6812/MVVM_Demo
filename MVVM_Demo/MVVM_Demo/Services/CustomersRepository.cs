using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVM_Demo.Model;

namespace MVVM_Demo.Services
{
    public class CustomersRepository : ICustomerRepository
    {
        private IList<Customer> customers;
        public CustomersRepository() 
        {
            customers = new List<Customer>();
        }
        public List<Customer> AddCustomer(Customer customer)
        {
            customers.Add(customer);
            return customers.ToList();
        }
        public List<Customer> DeleteCustomer(Customer customer)
        {
            if (customers.Any())
            {
                _ = customers.Remove(customer);                
            }
            return customers.ToList();
        }
        public Task<Customer> GetCustomerAsync(Guid id) => throw new NotImplementedException();
        public List<Customer> GetCustomers() => throw new NotImplementedException();
        public Task<Customer> UpdateCustomerAsync(Customer customer) => throw new NotImplementedException();
    }
}
