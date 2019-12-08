using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class TotalSalesRepository : Repository<TotalSalesEntity>, ITotalSalesRepository
    {
        public TotalSalesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
