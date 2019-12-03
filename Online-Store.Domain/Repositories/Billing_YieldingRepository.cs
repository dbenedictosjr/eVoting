using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Billing_YieldingRepository : Repository<Billing_YieldingEntity>, IBilling_YieldingRepository
    {
        public Billing_YieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
