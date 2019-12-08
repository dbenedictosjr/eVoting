using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class DiscountCardRepository : Repository<DiscountCardEntity>, IDiscountCardRepository
    {
        public DiscountCardRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
