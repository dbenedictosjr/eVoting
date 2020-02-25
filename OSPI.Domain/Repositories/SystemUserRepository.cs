using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SystemUserRepository : Repository<SystemUserEntity>, ISystemUserRepository
    {
        public SystemUserRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
