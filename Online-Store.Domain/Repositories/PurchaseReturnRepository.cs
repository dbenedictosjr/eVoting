using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class PurchaseReturnRepository : Repository<PurchaseReturnEntity>, IPurchaseReturnRepository
    {
        public PurchaseReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
