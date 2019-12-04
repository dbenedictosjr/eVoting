using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SalesOrder_DetailRepository : Repository<SalesOrder_DetailEntity>, ISalesOrder_DetailRepository
    {
        public SalesOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
