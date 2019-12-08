using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class PurchaseReturn_DetailRepository : Repository<PurchaseReturn_DetailEntity>, IPurchaseReturn_DetailRepository
    {
        public PurchaseReturn_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
