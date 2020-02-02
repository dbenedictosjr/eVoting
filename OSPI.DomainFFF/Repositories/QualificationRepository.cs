using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class QualificationRepository : Repository<QualificationEntity>, IQualificationRepository
    {
        public QualificationRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
