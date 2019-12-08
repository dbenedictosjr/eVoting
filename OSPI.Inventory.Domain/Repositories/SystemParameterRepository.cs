using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class SystemParameterRepository : Repository<SystemParameterEntity>, ISystemParameterRepository
    {
        public SystemParameterRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
