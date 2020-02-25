using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesReturnRepository : Repository<SalesReturnEntity>, ISalesReturnRepository
    {
        public SalesReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
