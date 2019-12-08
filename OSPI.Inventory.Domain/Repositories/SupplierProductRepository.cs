using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SupplierProductRepository : Repository<SupplierProductEntity>, ISupplierProductRepository
    {
        public SupplierProductRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
