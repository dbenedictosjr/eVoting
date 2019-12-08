using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PurchaseOrder_DetailRepository : Repository<PurchaseOrder_DetailEntity>, IPurchaseOrder_DetailRepository
    {
        public PurchaseOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
