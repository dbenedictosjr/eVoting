using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class PurchaseReturnRepository : Repository<PurchaseReturnEntity>, IPurchaseReturnRepository
    {
        public PurchaseReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
