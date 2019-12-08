using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ProductParStockRepository : Repository<ProductParStockEntity>, IProductParStockRepository
    {
        public ProductParStockRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
