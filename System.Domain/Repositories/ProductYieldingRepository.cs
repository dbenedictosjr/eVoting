using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductYieldingRepository : Repository<ProductYieldingEntity>, IProductYieldingRepository
    {
        public ProductYieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
