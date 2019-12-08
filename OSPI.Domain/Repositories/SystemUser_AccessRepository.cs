using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SystemUser_AccessRepository : Repository<SystemUser_AccessEntity>, ISystemUser_AccessRepository
    {
        public SystemUser_AccessRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
