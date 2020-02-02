using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class CandidateRepository : Repository<CandidateEntity>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}
