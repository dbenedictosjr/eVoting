using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Product_InventoryEntry_VarianceRepository : Repository<Product_InventoryEntry_VarianceEntity>, IProduct_InventoryEntry_VarianceRepository
    {
        public Product_InventoryEntry_VarianceRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
