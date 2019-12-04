using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class DiscountCardRepository : Repository<DiscountCardEntity>, IDiscountCardRepository
    {
        public DiscountCardRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
