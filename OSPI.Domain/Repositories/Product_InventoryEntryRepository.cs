using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Product_InventoryEntryRepository : Repository<Product_InventoryEntryEntity>, IProduct_InventoryEntryRepository
    {
        public Product_InventoryEntryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
