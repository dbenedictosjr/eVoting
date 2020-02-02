using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class VoteRepository : Repository<VoteEntity>, IVoteRepository
    {
        public VoteRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}
