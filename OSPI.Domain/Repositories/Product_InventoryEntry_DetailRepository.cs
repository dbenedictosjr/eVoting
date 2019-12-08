using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Product_InventoryEntry_DetailRepository : Repository<Product_InventoryEntry_DetailEntity>, IProduct_InventoryEntry_DetailRepository
    {
        public Product_InventoryEntry_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
