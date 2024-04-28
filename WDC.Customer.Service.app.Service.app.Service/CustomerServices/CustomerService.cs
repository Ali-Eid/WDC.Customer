using System;
using WDC.Customers.Data.Entities;
using WDC.Customers.Infrastructure.Bases.RepositoryBase;

namespace WDC.Customers.Service.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IGenericRepositoryAsync<Customer> _customerRepository;

        public CustomerService(IGenericRepositoryAsync<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var result = await _customerRepository.AddAsync(customer);
            return result;
        }

        public async Task DeleteCustomer(Customer customer)
        {
            var trans = _customerRepository.BeginTransaction();
            try
            {
                await _customerRepository.DeleteAsync(customer);
                await trans.CommitAsync();
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
            }
        }

        public Customer? GetCustomerById(int Id)
        {
            var result = _customerRepository.GetTableNoTracking().Where(x => x.Id == Id).FirstOrDefault();
            return result;
        }

        public async Task<List<Customer>> GetCustomersListAsync()
        {
            return await Task.FromResult(_customerRepository.GetTableNoTracking().ToList());
        }

        public async Task UpdateCustomer(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer);
        }
    }
}

