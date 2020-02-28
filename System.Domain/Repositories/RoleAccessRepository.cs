using System;
using System.Data.Entity;
using System.Domain.Entities;
using System.Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace System.Domain.Repositories
{
    public class RoleAccessRepository : Repository<RoleAccessEntity>, IRoleAccessRepository
    {
        public RoleAccessRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IEnumerable<RoleAccessEntity>> GetAllByRoleIDAsync(Guid id)
        {
            return await _context.Set<RoleAccessEntity>()
            .Include(a => a.Role)
            .Include(a => a.Module)
            .Where(a => a.RoleID == id)
            .ToListAsync();
        }
    }
}
