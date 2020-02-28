using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class BillingPaymentRepository : Repository<BillingPaymentEntity>, IBillingPaymentRepository
    {
        public BillingPaymentRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
