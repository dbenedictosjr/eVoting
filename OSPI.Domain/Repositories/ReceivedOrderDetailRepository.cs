using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ReceivedOrderDetailRepository : Repository<ReceivedOrderDetailEntity>, IReceivedOrderDetailRepository
    {
        public ReceivedOrderDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
