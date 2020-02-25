using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PurchaseOrderDetailRepository : Repository<PurchaseOrderDetailEntity>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
