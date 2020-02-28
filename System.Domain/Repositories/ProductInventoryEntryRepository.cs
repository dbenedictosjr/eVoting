using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductInventoryEntryRepository : Repository<ProductInventoryEntryEntity>, IProductInventoryEntryRepository
    {
        public ProductInventoryEntryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
