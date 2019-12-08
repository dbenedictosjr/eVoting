using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ModuleRepository : Repository<ModuleEntity>, IModuleRepository
    {
        public ModuleRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
