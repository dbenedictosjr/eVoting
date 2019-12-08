using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class PromoRepository : Repository<PromoEntity>, IPromoRepository
    {
        public PromoRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
