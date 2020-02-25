using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesReturnDetailRepository : Repository<SalesReturnDetailEntity>, ISalesReturnDetailRepository
    {
        public SalesReturnDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
