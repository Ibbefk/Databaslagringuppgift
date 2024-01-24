using Databaslagringuppgift.Repositories;
using Databaslagringuppgift.Tables;
using System;
using System.Collections.Generic;

namespace Databaslagringuppgift.Services
{
    internal class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            _customerRepository.DeleteCustomer(customerId);
        }
    }
}
