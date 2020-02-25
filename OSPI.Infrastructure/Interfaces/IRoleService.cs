using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPI.Infrastructure.Models;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IRoleService
    {
        Task CreateAsync(RoleModel role);

        Task<RoleModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<RoleModel>> GetAllAsync();

        Task UpdateAsync(RoleModel role);

        Task DeleteAsync(RoleModel role);

    }
}
