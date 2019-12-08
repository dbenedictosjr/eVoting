using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesOrderRepository : Repository<SalesOrderEntity>, ISalesOrderRepository
    {
        public SalesOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
