using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Product_YieldingRepository : Repository<Product_YieldingEntity>, IProduct_YieldingRepository
    {
        public Product_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
