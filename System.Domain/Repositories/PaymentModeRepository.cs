using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class PaymentModeRepository : Repository<PaymentModeEntity>, IPaymentModeRepository
    {
        public PaymentModeRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
