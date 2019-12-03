using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ReceivedOrder_DetailRepository : Repository<ReceivedOrder_DetailEntity>, IReceivedOrder_DetailRepository
    {
        public ReceivedOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
