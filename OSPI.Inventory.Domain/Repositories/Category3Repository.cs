using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Category3Repository : Repository<Category3Entity>, ICategory3Repository
    {
        public Category3Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
