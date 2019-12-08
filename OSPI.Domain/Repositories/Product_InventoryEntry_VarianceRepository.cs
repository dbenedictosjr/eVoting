using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Product_InventoryEntry_VarianceRepository : Repository<Product_InventoryEntry_VarianceEntity>, IProduct_InventoryEntry_VarianceRepository
    {
        public Product_InventoryEntry_VarianceRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
