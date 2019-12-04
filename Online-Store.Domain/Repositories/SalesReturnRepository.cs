using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SalesReturnRepository : Repository<SalesReturnEntity>, ISalesReturnRepository
    {
        public SalesReturnRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
