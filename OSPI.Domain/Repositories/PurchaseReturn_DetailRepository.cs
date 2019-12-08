using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PurchaseReturn_DetailRepository : Repository<PurchaseReturn_DetailEntity>, IPurchaseReturn_DetailRepository
    {
        public PurchaseReturn_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
