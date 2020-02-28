using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SalesOrderDetailRepository : Repository<SalesOrderDetailEntity>, ISalesOrderDetailRepository
    {
        public SalesOrderDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
