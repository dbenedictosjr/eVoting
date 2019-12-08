using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ProductParStock_DetailRepository : Repository<ProductParStock_DetailEntity>, IProductParStock_DetailRepository
    {
        public ProductParStock_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
