using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Billing_PaymentRepository : Repository<Billing_PaymentEntity>, IBilling_PaymentRepository
    {
        public Billing_PaymentRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
