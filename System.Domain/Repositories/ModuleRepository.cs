using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ModuleRepository : Repository<ModuleEntity>, IModuleRepository
    {
        public ModuleRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}
