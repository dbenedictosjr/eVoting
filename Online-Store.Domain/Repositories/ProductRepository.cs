using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
