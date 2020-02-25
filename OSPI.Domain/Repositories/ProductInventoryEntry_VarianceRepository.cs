using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductInventoryEntryVarianceRepository : Repository<ProductInventoryEntryVarianceEntity>, IProductInventoryEntryVarianceRepository
    {
        public ProductInventoryEntryVarianceRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
