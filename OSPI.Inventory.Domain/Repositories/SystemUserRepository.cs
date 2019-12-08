using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SystemUserRepository : Repository<SystemUserEntity>, ISystemUserRepository
    {
        public SystemUserRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
