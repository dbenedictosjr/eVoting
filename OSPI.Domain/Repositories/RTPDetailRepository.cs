using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class RTPDetailRepository : Repository<RTPDetailEntity>, IRTPDetailRepository
    {
        public RTPDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
