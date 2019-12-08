using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ReceivedOrder_DetailRepository : Repository<ReceivedOrder_DetailEntity>, IReceivedOrder_DetailRepository
    {
        public ReceivedOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
