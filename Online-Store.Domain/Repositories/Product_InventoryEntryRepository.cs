using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Product_InventoryEntryRepository : Repository<Product_InventoryEntryEntity>, IProduct_InventoryEntryRepository
    {
        public Product_InventoryEntryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
