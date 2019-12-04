using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class RTPRepository : Repository<RTPEntity>, IRTPRepository
    {
        public RTPRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
