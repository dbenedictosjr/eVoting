using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SalesReturnYieldingRepository : Repository<SalesReturnYieldingEntity>, ISalesReturnYieldingRepository
    {
        public SalesReturnYieldingRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
