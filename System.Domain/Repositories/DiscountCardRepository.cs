using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class DiscountCardRepository : Repository<DiscountCardEntity>, IDiscountCardRepository
    {
        public DiscountCardRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
