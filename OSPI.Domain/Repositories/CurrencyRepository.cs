using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class CurrencyRepository : Repository<CurrencyEntity>, ICurrencyRepository
    {
        public CurrencyRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
