using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Product_InventoryRepository : Repository<Product_InventoryEntity>, IProduct_InventoryRepository
    {
        public Product_InventoryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
