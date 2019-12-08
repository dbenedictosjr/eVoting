using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class PurchaseOrder_DetailRepository : Repository<PurchaseOrder_DetailEntity>, IPurchaseOrder_DetailRepository
    {
        public PurchaseOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
