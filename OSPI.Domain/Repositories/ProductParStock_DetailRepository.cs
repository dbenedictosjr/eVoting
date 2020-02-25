using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductParStockDetailRepository : Repository<ProductParStockDetailEntity>, IProductParStockDetailRepository
    {
        public ProductParStockDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
