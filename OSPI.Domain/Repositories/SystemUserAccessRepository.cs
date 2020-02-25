using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SystemUserAccessRepository : Repository<SystemUserAccessEntity>, ISystemUserAccessRepository
    {
        public SystemUserAccessRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
