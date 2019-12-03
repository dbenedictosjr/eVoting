using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ReceivedOrderRepository : Repository<ReceivedOrderEntity>, IReceivedOrderRepository
    {
        public ReceivedOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
