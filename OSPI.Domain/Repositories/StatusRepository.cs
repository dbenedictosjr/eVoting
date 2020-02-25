using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class StatusRepository : Repository<StatusEntity>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
