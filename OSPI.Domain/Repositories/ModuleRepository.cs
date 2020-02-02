using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ModuleRepository : Repository<ModuleEntity>, IModuleRepository
    {
        public ModuleRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}
