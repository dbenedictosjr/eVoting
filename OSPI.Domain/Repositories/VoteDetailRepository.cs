using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class VoteDetailRepository : Repository<VoteDetailEntity>, IVoteDetailRepository
    {
        public VoteDetailRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
        public override async Task<IEnumerable<VoteDetailEntity>> GetAllAsync()
        {
            return await _context.Set<VoteDetailEntity>()
            .Include(a => a.Vote)
            .Include(a => a.Candidate)
            .ToListAsync();
        }

        public override async Task<VoteDetailEntity> GetByIdAsync(Guid? id) => await _context.Set<VoteDetailEntity>()
            .Include(a => a.Vote)
            .Include(a => a.Candidate)
            .FirstOrDefaultAsync(a => a.VoteDetailID == id);

    }
}
