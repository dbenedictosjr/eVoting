using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;
using OSPI.Inventory.Infrastructure.Interfaces;
using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace OSPI.Inventory.Infrastructure.Services
{ }
    public class SystemParameterService : ISystemParameterService
    {
        private readonly ISystemParameterRepository SystemParameter;
    private readonly IMapper _mapper;

    public SystemParameterService(ISystemParameterRepository reposity, IMapper mapper)
    {
        SystemParameter = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SystemParameterModel model)
    {
        SystemParameter.Create(_mapper.Map<SystemParameterEntity>(model));
        await SystemParameter.SaveAsync();
    }

    public async Task DeleteAsync(SystemParameterModel model)
    {
        SystemParameter.Delete(_mapper.Map<SystemParameterEntity>(model));
        await SystemParameter.SaveAsync();
    }

    public async Task<IEnumerable<SystemParameterModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SystemParameterModel>>(await SystemParameter.GetAllAsync());

    public async Task<SystemParameterModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SystemParameterModel>(await SystemParameter.GetByIDAsync(id));

    public async Task UpdateAsync(SystemParameterModel model)
    {
        SystemParameter.Update(_mapper.Map<SystemParameterEntity>(model));
        await SystemParameter.SaveAsync();
    }
}