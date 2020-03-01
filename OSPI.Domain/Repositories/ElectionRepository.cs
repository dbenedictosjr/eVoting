using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class ElectionRepository : Repository<ElectionEntity>, IElectionRepository
    {
        public ElectionRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
        public override async Task<IEnumerable<ElectionEntity>> GetAllAsync()
        {
            return await _context.Set<ElectionEntity>()
            .Include(a => a.Member)
            .Include(a => a.Ballot)
            .ToListAsync();
        }

        public override async Task<ElectionEntity> GetByIdAsync(Guid? id) => await _context.Set<ElectionEntity>()
            .Include(a => a.Member)
            .Include(a => a.Ballot)
            .FirstOrDefaultAsync(a => a.ElectionId == id);
    }
}
