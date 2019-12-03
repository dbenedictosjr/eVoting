using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class PurchaseReturn_DetailRepository : Repository<PurchaseReturn_DetailEntity>, IPurchaseReturn_DetailRepository
    {
        public PurchaseReturn_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
