using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductInventoryEntryVarianceRepository : Repository<ProductInventoryEntryVarianceEntity>, IProductInventoryEntryVarianceRepository
    {
        public ProductInventoryEntryVarianceRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
