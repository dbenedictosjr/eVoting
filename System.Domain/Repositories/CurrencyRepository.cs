using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class CurrencyRepository : Repository<CurrencyEntity>, ICurrencyRepository
    {
        public CurrencyRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
