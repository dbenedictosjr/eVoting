using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class RoleRepository : Repository<RoleEntity>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public override async Task<RoleEntity> GetByIdAsync(Guid? id) => await _context.Set<RoleEntity>()
            .Include(a => a.RoleAccesses).ThenInclude(a => a.Module)
            .FirstOrDefaultAsync(a => a.RoleId == id);
    }
}
