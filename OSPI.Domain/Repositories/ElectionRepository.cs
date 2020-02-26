using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class ElectionRepository : Repository<ElectionEntity>, IElectionRepository
    {
        public ElectionRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override async Task<ElectionEntity> GetByIdAsync(Guid? id) => await _context.Set<ElectionEntity>()
            .Include(a => a.Positions)
            .FirstOrDefaultAsync(a => a.ElectionID == id);
    }
}
