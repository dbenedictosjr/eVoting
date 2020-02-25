using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PromoRepository : Repository<PromoEntity>, IPromoRepository
    {
        public PromoRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
