using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Billing_DetailRepository : Repository<Billing_DetailEntity>, IBilling_DetailRepository
    {
        public Billing_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
