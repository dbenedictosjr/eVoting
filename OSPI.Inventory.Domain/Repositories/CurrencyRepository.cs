using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class CurrencyRepository : Repository<CurrencyEntity>, ICurrencyRepository
    {
        public CurrencyRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
