using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SystemUser_AccessRepository : Repository<SystemUser_AccessEntity>, ISystemUser_AccessRepository
    {
        public SystemUser_AccessRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
