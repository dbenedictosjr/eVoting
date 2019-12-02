using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Billing_DetailRepository : Repository<Billing_DetailEntity>, IBilling_DetailRepository
    {
        public Billing_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
