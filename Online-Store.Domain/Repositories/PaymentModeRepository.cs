using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class PaymentModeRepository : Repository<PaymentModeEntity>, IPaymentModeRepository
    {
        public PaymentModeRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
