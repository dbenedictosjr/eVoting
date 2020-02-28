using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class Category3Repository : Repository<Category3Entity>, ICategory3Repository
    {
        public Category3Repository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
