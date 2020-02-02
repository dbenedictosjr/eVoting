using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class VoteRepository : Repository<VoteEntity>, IVoteRepository
    {
        public VoteRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
