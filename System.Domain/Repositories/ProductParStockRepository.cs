using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductParStockRepository : Repository<ProductParStockEntity>, IProductParStockRepository
    {
        public ProductParStockRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
