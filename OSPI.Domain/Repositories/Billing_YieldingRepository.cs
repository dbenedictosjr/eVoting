using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Billing_YieldingRepository : Repository<Billing_YieldingEntity>, IBilling_YieldingRepository
    {
        public Billing_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
