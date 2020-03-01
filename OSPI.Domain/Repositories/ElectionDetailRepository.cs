using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class ElectionDetailRepository : Repository<ElectionDetailEntity>, IElectionDetailRepository
    {
        public ElectionDetailRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
        public override async Task<IEnumerable<ElectionDetailEntity>> GetAllAsync()
        {
            return await _context.Set<ElectionDetailEntity>()
            .Include(a => a.Election)
            .Include(a => a.Candidate)
            .ToListAsync();
        }

        public override async Task<ElectionDetailEntity> GetByIdAsync(Guid? id) => await _context.Set<ElectionDetailEntity>()
            .Include(a => a.Election)
            .Include(a => a.Candidate)
            .FirstOrDefaultAsync(a => a.ElectionDetailId == id);

    }
}
