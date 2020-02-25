using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class Category3Repository : Repository<Category3Entity>, ICategory3Repository
    {
        public Category3Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
