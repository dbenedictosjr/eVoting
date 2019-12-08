using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SalesOrder_SlipRepository : Repository<SalesOrder_SlipEntity>, ISalesOrder_SlipRepository
    {
        public SalesOrder_SlipRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
