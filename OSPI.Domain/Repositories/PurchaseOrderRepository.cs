using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PurchaseOrderRepository : Repository<PurchaseOrderEntity>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
