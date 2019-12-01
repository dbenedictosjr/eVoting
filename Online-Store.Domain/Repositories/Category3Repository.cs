using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Category3Repository : Repository<Category3Entity>, ICategory3Repository
    {
        public Category3Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
