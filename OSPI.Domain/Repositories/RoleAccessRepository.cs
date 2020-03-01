using System;
using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace OSPI.Domain.Repositories
{
    public class RoleAccessRepository : Repository<RoleAccessEntity>, IRoleAccessRepository
    {
        public RoleAccessRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IEnumerable<RoleAccessEntity>> GetAllByRoleIdAsync(Guid id)
        {
            return await _context.Set<RoleAccessEntity>()
            .Include(a => a.Role)
            .Include(a => a.Module)
            .Where(a => a.RoleId == id)
            .ToListAsync();
        }

        public override async Task<IEnumerable<RoleAccessEntity>> GetAllAsync()
        {
            return await _context.Set<RoleAccessEntity>()
            .Include(a => a.Role)
            .Include(a => a.Module)
            .ToListAsync();
        }
    }
}
