using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class TotalSalesRepository : Repository<TotalSalesEntity>, ITotalSalesRepository
    {
        public TotalSalesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
