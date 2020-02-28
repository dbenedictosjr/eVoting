using System.Data.Entity;
using System.Domain.Entities;
using System.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace System.Domain.Repositories
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
