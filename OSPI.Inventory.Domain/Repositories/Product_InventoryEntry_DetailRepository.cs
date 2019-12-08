using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Product_InventoryEntry_DetailRepository : Repository<Product_InventoryEntry_DetailEntity>, IProduct_InventoryEntry_DetailRepository
    {
        public Product_InventoryEntry_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
