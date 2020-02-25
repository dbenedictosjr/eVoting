using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductYieldingRepository : Repository<ProductYieldingEntity>, IProductYieldingRepository
    {
        public ProductYieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
