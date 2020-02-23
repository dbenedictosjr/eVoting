using OSPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Interfaces
{
    public interface IRoleAccessRepository : IRepository<RoleAccessEntity>
    {
        Task<IEnumerable<RoleAccessEntity>> GetAllByRoleIDAsync(Guid id);
    }
}
