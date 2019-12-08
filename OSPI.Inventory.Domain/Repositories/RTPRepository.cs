using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class RTPRepository : Repository<RTPEntity>, IRTPRepository
    {
        public RTPRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
