using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class BallotRepository : Repository<BallotEntity>, IBallotRepository
    {
        public BallotRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
