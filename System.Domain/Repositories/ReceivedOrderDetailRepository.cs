using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ReceivedOrderDetailRepository : Repository<ReceivedOrderDetailEntity>, IReceivedOrderDetailRepository
    {
        public ReceivedOrderDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
