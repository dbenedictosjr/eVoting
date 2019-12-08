using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ProductParStock_DetailRepository : Repository<ProductParStock_DetailEntity>, IProductParStock_DetailRepository
    {
        public ProductParStock_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
