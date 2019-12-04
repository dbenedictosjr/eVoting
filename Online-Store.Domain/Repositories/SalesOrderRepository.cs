using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SalesOrderRepository : Repository<SalesOrderEntity>, ISalesOrderRepository
    {
        public SalesOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
