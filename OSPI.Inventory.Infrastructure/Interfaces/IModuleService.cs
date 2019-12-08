using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IModuleService
    {
        Task CreateAsync(ModuleModel model);

        Task<ModuleModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ModuleModel>> GetAllAsync();

        Task UpdateAsync(ModuleModel model);

        Task DeleteAsync(ModuleModel model);

    }
}