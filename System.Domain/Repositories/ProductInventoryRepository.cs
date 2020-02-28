using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductInventoryRepository : Repository<ProductInventoryEntity>, IProductInventoryRepository
    {
        public ProductInventoryRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
