using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPI.Infrastructure.Models;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IRoleAccessService
    {
        Task CreateAsync(RoleAccessModel roleAccess);

        Task<RoleAccessModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<RoleAccessModel>> GetAllByRoleIdAsync(Guid id);
        Task<IEnumerable<RoleAccessModel>> GetAllAsync();

        Task UpdateAsync(RoleAccessModel roleAccess);

        Task DeleteAsync(RoleAccessModel roleAccess);

    }
}
