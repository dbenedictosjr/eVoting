using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class BillingDetailRepository : Repository<BillingDetailEntity>, IBillingDetailRepository
    {
        public BillingDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
