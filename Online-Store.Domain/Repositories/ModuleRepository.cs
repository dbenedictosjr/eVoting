using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ModuleRepository : Repository<ModuleEntity>, IModuleRepository
    {
        public ModuleRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
