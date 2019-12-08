using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SalesOrderRepository : Repository<SalesOrderEntity>, ISalesOrderRepository
    {
        public SalesOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
