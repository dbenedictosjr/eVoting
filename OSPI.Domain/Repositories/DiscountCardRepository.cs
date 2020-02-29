using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class DiscountCardRepository : Repository<DiscountCardEntity>, IdiscountCardRepository
    {
        public DiscountCardRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
