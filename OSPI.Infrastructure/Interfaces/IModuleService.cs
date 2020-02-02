using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
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