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
    public class SystemUserService : ISystemUserService
    {
        private readonly ISystemUserRepository SystemUser;
    private readonly IMapper _mapper;

    public SystemUserService(ISystemUserRepository reposity, IMapper mapper)
    {
        SystemUser = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SystemUserModel model)
    {
        SystemUser.Create(_mapper.Map<SystemUserEntity>(model));
        await SystemUser.SaveAsync();
    }

    public async Task DeleteAsync(SystemUserModel model)
    {
        SystemUser.Delete(_mapper.Map<SystemUserEntity>(model));
        await SystemUser.SaveAsync();
    }

    public async Task<IEnumerable<SystemUserModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SystemUserModel>>(await SystemUser.GetAllAsync());

    public async Task<SystemUserModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SystemUserModel>(await SystemUser.GetByIDAsync(id));

    public async Task UpdateAsync(SystemUserModel model)
    {
        SystemUser.Update(_mapper.Map<SystemUserEntity>(model));
        await SystemUser.SaveAsync();
    }
}