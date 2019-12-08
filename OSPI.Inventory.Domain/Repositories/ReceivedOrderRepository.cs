using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ReceivedOrderRepository : Repository<ReceivedOrderEntity>, IReceivedOrderRepository
    {
        public ReceivedOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
