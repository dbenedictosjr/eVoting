using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class StoreRepository : Repository<StoreEntity>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
