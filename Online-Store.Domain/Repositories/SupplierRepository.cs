using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SupplierRepository : Repository<SupplierEntity>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
