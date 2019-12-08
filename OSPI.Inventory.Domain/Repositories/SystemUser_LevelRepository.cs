using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SystemUser_LevelRepository : Repository<SystemUser_LevelEntity>, ISystemUser_LevelRepository
    {
        public SystemUser_LevelRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
