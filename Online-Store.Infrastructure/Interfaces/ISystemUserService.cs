using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
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