using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;
using Online_Store.Infrastructure.Interfaces;
using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Online_Store.Infrastructure.Services
{ }
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository Customer;
    private readonly IMapper _mapper;

    public CustomerService(ICustomerRepository reposity, IMapper mapper)
    {
        Customer = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(CustomerModel model)
    {
        Customer.Create(_mapper.Map<CustomerEntity>(model));
        await Customer.SaveAsync();
    }

    public async Task DeleteAsync(CustomerModel model)
    {
        Customer.Delete(_mapper.Map<CustomerEntity>(model));
        await Customer.SaveAsync();
    }

    public async Task<IEnumerable<CustomerModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<CustomerModel>>(await Customer.GetAllAsync());

    public async Task<CustomerModel> GetByIDAsync(Guid? id)
        => _mapper.Map<CustomerModel>(await Customer.GetByIDAsync(id));

    public async Task UpdateAsync(CustomerModel model)
    {
        Customer.Update(_mapper.Map<CustomerEntity>(model));
        await Customer.SaveAsync();
    }
}