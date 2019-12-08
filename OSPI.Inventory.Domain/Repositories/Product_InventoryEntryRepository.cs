using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Product_InventoryEntryRepository : Repository<Product_InventoryEntryEntity>, IProduct_InventoryEntryRepository
    {
        public Product_InventoryEntryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
