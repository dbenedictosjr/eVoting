using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class Category1Repository : Repository<Category1Entity>, ICategory1Repository
    {
        public Category1Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
