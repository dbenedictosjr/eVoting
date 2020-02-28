using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class BillingYieldingRepository : Repository<BillingYieldingEntity>, IBillingYieldingRepository
    {
        public BillingYieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
