using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class DiscountRepository : Repository<DiscountEntity>, IDiscountRepository
    {
        public DiscountRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
