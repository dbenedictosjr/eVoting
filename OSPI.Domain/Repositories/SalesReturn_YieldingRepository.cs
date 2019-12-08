using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesReturn_YieldingRepository : Repository<SalesReturn_YieldingEntity>, ISalesReturn_YieldingRepository
    {
        public SalesReturn_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
