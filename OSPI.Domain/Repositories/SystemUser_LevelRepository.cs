using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SystemUser_LevelRepository : Repository<SystemUser_LevelEntity>, ISystemUser_LevelRepository
    {
        public SystemUser_LevelRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
