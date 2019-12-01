using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Category2Repository : Repository<Category2Entity>, ICategory2Repository
    {
        public Category2Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
