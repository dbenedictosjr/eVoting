using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class StoreRepository : Repository<StoreEntity>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
