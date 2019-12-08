using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Product_UnitRepository : Repository<Product_UnitEntity>, IProduct_UnitRepository
    {
        public Product_UnitRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
