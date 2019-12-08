using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Billing_YieldingRepository : Repository<Billing_YieldingEntity>, IBilling_YieldingRepository
    {
        public Billing_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
