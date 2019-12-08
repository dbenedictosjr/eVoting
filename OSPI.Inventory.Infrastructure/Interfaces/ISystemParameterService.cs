using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ISystemParameterService
    {
        Task CreateAsync(SystemParameterModel model);

        Task<SystemParameterModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SystemParameterModel>> GetAllAsync();

        Task UpdateAsync(SystemParameterModel model);

        Task DeleteAsync(SystemParameterModel model);

    }
}