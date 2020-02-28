using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class PurchaseReturnRepository : Repository<PurchaseReturnEntity>, IPurchaseReturnRepository
    {
        public PurchaseReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
