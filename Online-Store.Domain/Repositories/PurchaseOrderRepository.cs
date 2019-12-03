using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class PurchaseOrderRepository : Repository<PurchaseOrderEntity>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
