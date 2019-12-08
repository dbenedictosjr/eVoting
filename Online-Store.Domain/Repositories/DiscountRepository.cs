using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class DiscountRepository : Repository<DiscountEntity>, IDiscountRepository
    {
        public DiscountRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
