using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SalesOrder_SlipRepository : Repository<SalesOrder_SlipEntity>, ISalesOrder_SlipRepository
    {
        public SalesOrder_SlipRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
