using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Billing_PaymentRepository : Repository<Billing_PaymentEntity>, IBilling_PaymentRepository
    {
        public Billing_PaymentRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
