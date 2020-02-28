using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductInventoryEntryDetailRepository : Repository<ProductInventoryEntryDetailEntity>, IProductInventoryEntryDetailRepository
    {
        public ProductInventoryEntryDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
