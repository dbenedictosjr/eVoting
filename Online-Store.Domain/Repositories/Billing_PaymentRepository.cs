using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Billing_PaymentRepository : Repository<Billing_PaymentEntity>, IBilling_PaymentRepository
    {
        public Billing_PaymentRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
