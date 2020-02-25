using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PurchaseReturnDetailRepository : Repository<PurchaseReturnDetailEntity>, IPurchaseReturnDetailRepository
    {
        public PurchaseReturnDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
