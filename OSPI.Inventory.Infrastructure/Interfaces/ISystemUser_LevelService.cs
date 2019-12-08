using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ISystemUser_LevelService
    {
        Task CreateAsync(SystemUser_LevelModel model);

        Task<SystemUser_LevelModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SystemUser_LevelModel>> GetAllAsync();

        Task UpdateAsync(SystemUser_LevelModel model);

        Task DeleteAsync(SystemUser_LevelModel model);

    }
}