using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesOrderSlipRepository : Repository<SalesOrderSlipEntity>, ISalesOrderSlipRepository
    {
        public SalesOrderSlipRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
