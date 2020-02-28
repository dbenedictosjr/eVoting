using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class TotalSalesRepository : Repository<TotalSalesEntity>, ITotalSalesRepository
    {
        public TotalSalesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
