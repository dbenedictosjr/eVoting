using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductInventoryRepository : Repository<ProductInventoryEntity>, IProductInventoryRepository
    {
        public ProductInventoryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
