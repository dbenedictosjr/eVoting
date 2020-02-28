using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SalesOrderSlipRepository : Repository<SalesOrderSlipEntity>, ISalesOrderSlipRepository
    {
        public SalesOrderSlipRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
