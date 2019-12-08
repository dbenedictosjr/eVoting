using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Category2Repository : Repository<Category2Entity>, ICategory2Repository
    {
        public Category2Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
