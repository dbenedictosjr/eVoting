using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductInventoryEntryRepository : Repository<ProductInventoryEntryEntity>, IProductInventoryEntryRepository
    {
        public ProductInventoryEntryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
