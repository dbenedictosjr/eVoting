using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class PurchaseOrderDetailRepository : Repository<PurchaseOrderDetailEntity>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
