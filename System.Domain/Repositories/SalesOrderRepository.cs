using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SalesOrderRepository : Repository<SalesOrderEntity>, ISalesOrderRepository
    {
        public SalesOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
