using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVM_Demo.Model;

namespace MVVM_Demo.Services
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Task<Customer> GetCustomerAsync(Guid id);
        List<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomerAsync(Customer customer);
        List<Customer> DeleteCustomer(Customer customer);
    }
}
