using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Product_YieldingRepository : Repository<Product_YieldingEntity>, IProduct_YieldingRepository
    {
        public Product_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
