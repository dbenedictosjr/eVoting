using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PaymentModeRepository : Repository<PaymentModeEntity>, IPaymentModeRepository
    {
        public PaymentModeRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
