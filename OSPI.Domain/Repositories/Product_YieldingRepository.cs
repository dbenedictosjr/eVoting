using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Product_YieldingRepository : Repository<Product_YieldingEntity>, IProduct_YieldingRepository
    {
        public Product_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
