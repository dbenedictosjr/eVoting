using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class BillingYieldingRepository : Repository<BillingYieldingEntity>, IBillingYieldingRepository
    {
        public BillingYieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
