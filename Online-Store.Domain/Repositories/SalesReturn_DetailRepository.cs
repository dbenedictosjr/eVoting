using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SalesReturn_DetailRepository : Repository<SalesReturn_DetailEntity>, ISalesReturn_DetailRepository
    {
        public SalesReturn_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
