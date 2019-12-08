using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SalesReturn_YieldingRepository : Repository<SalesReturn_YieldingEntity>, ISalesReturn_YieldingRepository
    {
        public SalesReturn_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
