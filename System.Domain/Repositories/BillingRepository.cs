using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class BillingRepository : Repository<BillingEntity>, IBillingRepository
    {
        public BillingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
