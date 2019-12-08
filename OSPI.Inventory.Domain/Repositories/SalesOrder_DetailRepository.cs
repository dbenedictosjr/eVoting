using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SalesOrder_DetailRepository : Repository<SalesOrder_DetailEntity>, ISalesOrder_DetailRepository
    {
        public SalesOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
