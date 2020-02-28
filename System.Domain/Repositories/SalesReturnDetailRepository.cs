using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SalesReturnDetailRepository : Repository<SalesReturnDetailEntity>, ISalesReturnDetailRepository
    {
        public SalesReturnDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
