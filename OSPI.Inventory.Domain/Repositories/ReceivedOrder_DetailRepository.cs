using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ReceivedOrder_DetailRepository : Repository<ReceivedOrder_DetailEntity>, IReceivedOrder_DetailRepository
    {
        public ReceivedOrder_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
