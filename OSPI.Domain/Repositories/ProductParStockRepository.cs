using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductParStockRepository : Repository<ProductParStockEntity>, IProductParStockRepository
    {
        public ProductParStockRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
