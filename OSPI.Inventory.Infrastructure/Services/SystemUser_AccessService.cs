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
    public class SystemUser_AccessService : ISystemUser_AccessService
    {
        private readonly ISystemUser_AccessRepository SystemUser_Access;
    private readonly IMapper _mapper;

    public SystemUser_AccessService(ISystemUser_AccessRepository reposity, IMapper mapper)
    {
        SystemUser_Access = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SystemUser_AccessModel model)
    {
        SystemUser_Access.Create(_mapper.Map<SystemUser_AccessEntity>(model));
        await SystemUser_Access.SaveAsync();
    }

    public async Task DeleteAsync(SystemUser_AccessModel model)
    {
        SystemUser_Access.Delete(_mapper.Map<SystemUser_AccessEntity>(model));
        await SystemUser_Access.SaveAsync();
    }

    public async Task<IEnumerable<SystemUser_AccessModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SystemUser_AccessModel>>(await SystemUser_Access.GetAllAsync());

    public async Task<SystemUser_AccessModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SystemUser_AccessModel>(await SystemUser_Access.GetByIDAsync(id));

    public async Task UpdateAsync(SystemUser_AccessModel model)
    {
        SystemUser_Access.Update(_mapper.Map<SystemUser_AccessEntity>(model));
        await SystemUser_Access.SaveAsync();
    }
}