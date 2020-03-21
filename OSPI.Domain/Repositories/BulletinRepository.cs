using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class BulletinRepository : Repository<BulletinEntity>, IBulletinRepository
    {
        public BulletinRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public override async Task<IEnumerable<BulletinEntity>> GetAllAsync()
        {
            return await _context.Set<BulletinEntity>()
            .Include(a => a.Member)
            .ToListAsync();
        }

        public override async Task<BulletinEntity> GetByIdAsync(Guid? id) => await _context.Set<BulletinEntity>()
            .Include(a => a.Member)
            .FirstOrDefaultAsync(a => a.BulletinId == id);
    }
}
