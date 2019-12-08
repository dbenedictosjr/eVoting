using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ISystemUserService
    {
        Task CreateAsync(SystemUserModel model);

        Task<SystemUserModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SystemUserModel>> GetAllAsync();

        Task UpdateAsync(SystemUserModel model);

        Task DeleteAsync(SystemUserModel model);

    }
}