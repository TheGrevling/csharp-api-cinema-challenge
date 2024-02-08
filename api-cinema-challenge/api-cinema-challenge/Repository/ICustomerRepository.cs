﻿using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.NewFolder;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<Customer> CreateCustomer(CustomerInputDTO input);
        public Task<Customer> UpdateCustomer(CustomerInputDTO input, int id);
        public Task<Customer> DeleteCustomer(int id);
    }
}