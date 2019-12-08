using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Billing_DetailRepository : Repository<Billing_DetailEntity>, IBilling_DetailRepository
    {
        public Billing_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
