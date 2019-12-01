using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class Category1Repository : Repository<Category1Entity>, ICategory1Repository
    {
        public Category1Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
