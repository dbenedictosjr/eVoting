using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class RTPRepository : Repository<RTPEntity>, IRTPRepository
    {
        public RTPRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
