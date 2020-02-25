using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Category1Repository : Repository<Category1Entity>, ICategory1Repository
    {
        public Category1Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
