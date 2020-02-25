using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesOrderDetailRepository : Repository<SalesOrderDetailEntity>, ISalesOrderDetailRepository
    {
        public SalesOrderDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
