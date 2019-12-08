using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SalesReturn_DetailRepository : Repository<SalesReturn_DetailEntity>, ISalesReturn_DetailRepository
    {
        public SalesReturn_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
