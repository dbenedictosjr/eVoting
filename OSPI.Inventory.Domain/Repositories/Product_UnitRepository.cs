using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Product_UnitRepository : Repository<Product_UnitEntity>, IProduct_UnitRepository
    {
        public Product_UnitRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
