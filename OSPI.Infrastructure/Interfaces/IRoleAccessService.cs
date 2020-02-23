using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPI.Infrastructure.Models;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IRoleAccessService
    {
        Task CreateAsync(RoleAccessModel model);

        Task<RoleAccessModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<RoleAccessModel>> GetAllByRoleIDAsync(Guid id);
        Task<IEnumerable<RoleAccessModel>> GetAllAsync();

        Task UpdateAsync(RoleAccessModel model);

        Task DeleteAsync(RoleAccessModel model);

    }
}
