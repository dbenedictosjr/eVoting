using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ReceivedOrderRepository : Repository<ReceivedOrderEntity>, IReceivedOrderRepository
    {
        public ReceivedOrderRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
