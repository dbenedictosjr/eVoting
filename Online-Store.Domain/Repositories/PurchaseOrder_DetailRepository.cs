using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class PurchaseOrder_DetailRepository : Repository<PurchaseOrder_DetailEntity>, IPurchaseOrder_DetailRepository
    {
        public PurchaseOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
