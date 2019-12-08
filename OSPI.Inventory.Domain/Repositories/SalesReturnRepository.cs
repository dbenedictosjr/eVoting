using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SalesReturnRepository : Repository<SalesReturnEntity>, ISalesReturnRepository
    {
        public SalesReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
