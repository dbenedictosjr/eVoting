using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesReturn_DetailRepository : Repository<SalesReturn_DetailEntity>, ISalesReturn_DetailRepository
    {
        public SalesReturn_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
