using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ProductParStockRepository : Repository<ProductParStockEntity>, IProductParStockRepository
    {
        public ProductParStockRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
