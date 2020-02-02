using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class CandidateRepository : Repository<CandidateEntity>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
