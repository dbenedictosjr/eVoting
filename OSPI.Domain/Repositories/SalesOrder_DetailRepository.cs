using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesOrder_DetailRepository : Repository<SalesOrder_DetailEntity>, ISalesOrder_DetailRepository
    {
        public SalesOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
