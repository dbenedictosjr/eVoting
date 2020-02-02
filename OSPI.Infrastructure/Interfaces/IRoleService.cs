using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPI.Infrastructure.Models;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IRoleService
    {
        Task CreateAsync(RoleModel model);

        Task<RoleModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<RoleModel>> GetAllAsync();

        Task UpdateAsync(RoleModel model);

        Task DeleteAsync(RoleModel model);

    }
}
