using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class PromoRepository : Repository<PromoEntity>, IPromoRepository
    {
        public PromoRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
