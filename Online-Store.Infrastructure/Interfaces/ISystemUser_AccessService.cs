using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ISystemUser_AccessService
    {
        Task CreateAsync(SystemUser_AccessModel model);

        Task<SystemUser_AccessModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SystemUser_AccessModel>> GetAllAsync();

        Task UpdateAsync(SystemUser_AccessModel model);

        Task DeleteAsync(SystemUser_AccessModel model);

    }
}