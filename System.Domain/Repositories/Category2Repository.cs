using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class Category2Repository : Repository<Category2Entity>, ICategory2Repository
    {
        public Category2Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
