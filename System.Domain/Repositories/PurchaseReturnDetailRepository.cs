using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class PurchaseReturnDetailRepository : Repository<PurchaseReturnDetailEntity>, IPurchaseReturnDetailRepository
    {
        public PurchaseReturnDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
