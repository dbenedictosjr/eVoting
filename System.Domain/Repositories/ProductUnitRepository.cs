using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ProductUnitRepository : Repository<ProductUnitEntity>, IProductUnitRepository
    {
        public ProductUnitRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
