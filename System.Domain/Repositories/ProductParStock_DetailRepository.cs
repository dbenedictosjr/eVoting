using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductParStockDetailRepository : Repository<ProductParStockDetailEntity>, IProductParStockDetailRepository
    {
        public ProductParStockDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
