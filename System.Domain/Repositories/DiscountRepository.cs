using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class DiscountRepository : Repository<DiscountEntity>, IDiscountRepository
    {
        public DiscountRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
