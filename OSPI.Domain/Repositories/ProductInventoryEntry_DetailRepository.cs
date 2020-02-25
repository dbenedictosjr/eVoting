using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductInventoryEntryDetailRepository : Repository<ProductInventoryEntryDetailEntity>, IProductInventoryEntryDetailRepository
    {
        public ProductInventoryEntryDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
