using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Category2Repository : Repository<Category2Entity>, ICategory2Repository
    {
        public Category2Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
