using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesReturnYieldingRepository : Repository<SalesReturnYieldingEntity>, ISalesReturnYieldingRepository
    {
        public SalesReturnYieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
