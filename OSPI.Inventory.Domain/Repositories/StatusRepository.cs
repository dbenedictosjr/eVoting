using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class StatusRepository : Repository<StatusEntity>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
