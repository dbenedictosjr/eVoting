using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SupplierProductRepository : Repository<SupplierProductEntity>, ISupplierProductRepository
    {
        public SupplierProductRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
