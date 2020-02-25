using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SystemUserLevelRepository : Repository<SystemUserLevelEntity>, ISystemUserLevelRepository
    {
        public SystemUserLevelRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
