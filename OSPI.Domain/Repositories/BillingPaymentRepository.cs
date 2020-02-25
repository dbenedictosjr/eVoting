using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class BillingPaymentRepository : Repository<BillingPaymentEntity>, IBillingPaymentRepository
    {
        public BillingPaymentRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
