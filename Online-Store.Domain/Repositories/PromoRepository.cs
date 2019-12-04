using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class PromoRepository : Repository<PromoEntity>, IPromoRepository
    {
        public PromoRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
