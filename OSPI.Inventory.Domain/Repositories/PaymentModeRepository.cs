using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class PaymentModeRepository : Repository<PaymentModeEntity>, IPaymentModeRepository
    {
        public PaymentModeRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
