using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Product_InventoryRepository : Repository<Product_InventoryEntity>, IProduct_InventoryRepository
    {
        public Product_InventoryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
