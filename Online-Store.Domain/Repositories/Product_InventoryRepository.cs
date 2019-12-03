using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Product_InventoryRepository : Repository<Product_InventoryEntity>, IProduct_InventoryRepository
    {
        public Product_InventoryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
