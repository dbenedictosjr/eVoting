using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
