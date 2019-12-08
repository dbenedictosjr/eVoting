using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PurchaseReturnRepository : Repository<PurchaseReturnEntity>, IPurchaseReturnRepository
    {
        public PurchaseReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
