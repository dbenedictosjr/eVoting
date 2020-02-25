using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SupplierRepository : Repository<SupplierEntity>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
