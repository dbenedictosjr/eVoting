using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ProductParStock_DetailRepository : Repository<ProductParStock_DetailEntity>, IProductParStock_DetailRepository
    {
        public ProductParStock_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
