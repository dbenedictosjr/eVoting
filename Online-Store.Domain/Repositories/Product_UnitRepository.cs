using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Product_UnitRepository : Repository<Product_UnitEntity>, IProduct_UnitRepository
    {
        public Product_UnitRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
