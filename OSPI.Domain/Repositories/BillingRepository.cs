using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class BillingRepository : Repository<BillingEntity>, IBillingRepository
    {
        public BillingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
