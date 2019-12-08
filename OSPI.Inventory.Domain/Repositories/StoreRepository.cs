using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class StoreRepository : Repository<StoreEntity>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
