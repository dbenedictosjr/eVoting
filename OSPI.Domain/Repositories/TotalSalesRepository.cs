using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class TotalSalesRepository : Repository<TotalSalesEntity>, ITotalSalesRepository
    {
        public TotalSalesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
