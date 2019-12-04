using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SalesReturn_YieldingRepository : Repository<SalesReturn_YieldingEntity>, ISalesReturn_YieldingRepository
    {
        public SalesReturn_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
