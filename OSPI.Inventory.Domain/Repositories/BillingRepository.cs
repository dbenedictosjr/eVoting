using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class BillingRepository : Repository<BillingEntity>, IBillingRepository
    {
        public BillingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
