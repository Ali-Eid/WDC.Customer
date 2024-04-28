using System;
using WDC.Customers.Data.Entities;

namespace WDC.Customers.Service.CustomerServices
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetCustomersListAsync();

        public Customer? GetCustomerById(int Id);

        public Task<Customer> CreateCustomer(Customer customer);

        public Task UpdateCustomer(Customer customer);

        public Task DeleteCustomer(Customer customer);

    }
}

