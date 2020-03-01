using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class BallotRepository : Repository<BallotEntity>, IBallotRepository
    {
        public BallotRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override async Task<BallotEntity> GetByIdAsync(Guid? id) => await _context.Set<BallotEntity>()
            .Include(a => a.Positions)
            .FirstOrDefaultAsync(a => a.BallotId == id);
    }
}
