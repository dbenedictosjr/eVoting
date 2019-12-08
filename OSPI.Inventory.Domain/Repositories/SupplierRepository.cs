using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SupplierRepository : Repository<SupplierEntity>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
