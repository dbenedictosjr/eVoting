using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SupplierProductRepository : Repository<SupplierProductEntity>, ISupplierProductRepository
    {
        public SupplierProductRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
