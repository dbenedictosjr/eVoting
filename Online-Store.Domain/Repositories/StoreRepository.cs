using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class StoreRepository : Repository<StoreEntity>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
