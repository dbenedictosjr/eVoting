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
    public class SystemUser_LevelService : ISystemUser_LevelService
    {
        private readonly ISystemUser_LevelRepository SystemUser_Level;
    private readonly IMapper _mapper;

    public SystemUser_LevelService(ISystemUser_LevelRepository reposity, IMapper mapper)
    {
        SystemUser_Level = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SystemUser_LevelModel model)
    {
        SystemUser_Level.Create(_mapper.Map<SystemUser_LevelEntity>(model));
        await SystemUser_Level.SaveAsync();
    }

    public async Task DeleteAsync(SystemUser_LevelModel model)
    {
        SystemUser_Level.Delete(_mapper.Map<SystemUser_LevelEntity>(model));
        await SystemUser_Level.SaveAsync();
    }

    public async Task<IEnumerable<SystemUser_LevelModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SystemUser_LevelModel>>(await SystemUser_Level.GetAllAsync());

    public async Task<SystemUser_LevelModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SystemUser_LevelModel>(await SystemUser_Level.GetByIDAsync(id));

    public async Task UpdateAsync(SystemUser_LevelModel model)
    {
        SystemUser_Level.Update(_mapper.Map<SystemUser_LevelEntity>(model));
        await SystemUser_Level.SaveAsync();
    }
}