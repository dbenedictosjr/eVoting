using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Product_InventoryEntry_DetailRepository : Repository<Product_InventoryEntry_DetailEntity>, IProduct_InventoryEntry_DetailRepository
    {
        public Product_InventoryEntry_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
