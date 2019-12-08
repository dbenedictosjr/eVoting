using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SupplierProductRepository : Repository<SupplierProductEntity>, ISupplierProductRepository
    {
        public SupplierProductRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
