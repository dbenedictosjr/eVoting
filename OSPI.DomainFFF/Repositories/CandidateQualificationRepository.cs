using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class CandidateQualificationRepository : Repository<CandidateQualificationEntity>, ICandidateQualificationRepository
    {
        public CandidateQualificationRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
