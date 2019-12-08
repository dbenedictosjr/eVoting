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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository Employee;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeRepository reposity, IMapper mapper)
    {
        Employee = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(EmployeeModel model)
    {
        Employee.Create(_mapper.Map<EmployeeEntity>(model));
        await Employee.SaveAsync();
    }

    public async Task DeleteAsync(EmployeeModel model)
    {
        Employee.Delete(_mapper.Map<EmployeeEntity>(model));
        await Employee.SaveAsync();
    }

    public async Task<IEnumerable<EmployeeModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<EmployeeModel>>(await Employee.GetAllAsync());

    public async Task<EmployeeModel> GetByIDAsync(Guid? id)
        => _mapper.Map<EmployeeModel>(await Employee.GetByIDAsync(id));

    public async Task UpdateAsync(EmployeeModel model)
    {
        Employee.Update(_mapper.Map<EmployeeEntity>(model));
        await Employee.SaveAsync();
    }
}