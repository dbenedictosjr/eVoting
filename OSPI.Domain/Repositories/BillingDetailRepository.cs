using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class BillingDetailRepository : Repository<BillingDetailEntity>, IBillingDetailRepository
    {
        public BillingDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
