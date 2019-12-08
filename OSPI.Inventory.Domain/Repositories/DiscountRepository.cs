using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class DiscountRepository : Repository<DiscountEntity>, IDiscountRepository
    {
        public DiscountRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
