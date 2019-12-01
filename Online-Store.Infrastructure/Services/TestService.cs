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
    public class TestService : ITestService
    {
        private readonly ITestRepository Test;
    private readonly IMapper _mapper;

    public TestService(ITestRepository reposity, IMapper mapper)
    {
        Test = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(TestModel model)
    {
        Test.Create(_mapper.Map<TestEntity>(model));
        await Test.SaveAsync();
    }

    public async Task DeleteAsync(TestModel model)
    {
        Test.Delete(_mapper.Map<TestEntity>(model));
        await Test.SaveAsync();
    }

    public async Task<IEnumerable<TestModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<TestModel>>(await Test.GetAllAsync());

    public async Task<TestModel> GetByIDAsync(Guid? id)
        => _mapper.Map<TestModel>(await Test.GetByIDAsync(id));

    public async Task UpdateAsync(TestModel model)
    {
        Test.Update(_mapper.Map<TestEntity>(model));
        await Test.SaveAsync();
    }
}