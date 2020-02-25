using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ReceivedOrderRepository : Repository<ReceivedOrderEntity>, IReceivedOrderRepository
    {
        public ReceivedOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
