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
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository Module;
    private readonly IMapper _mapper;

    public ModuleService(IModuleRepository reposity, IMapper mapper)
    {
        Module = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ModuleModel model)
    {
        Module.Create(_mapper.Map<ModuleEntity>(model));
        await Module.SaveAsync();
    }

    public async Task DeleteAsync(ModuleModel model)
    {
        Module.Delete(_mapper.Map<ModuleEntity>(model));
        await Module.SaveAsync();
    }

    public async Task<IEnumerable<ModuleModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ModuleModel>>(await Module.GetAllAsync());

    public async Task<ModuleModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ModuleModel>(await Module.GetByIDAsync(id));

    public async Task UpdateAsync(ModuleModel model)
    {
        Module.Update(_mapper.Map<ModuleEntity>(model));
        await Module.SaveAsync();
    }
}