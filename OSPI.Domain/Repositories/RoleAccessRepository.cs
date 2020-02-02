using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class RoleAccessRepository : Repository<RoleAccessEntity>, IRoleAccessRepository
    {
        public RoleAccessRepository(ApplicationDbContext context) 
            : base(context)
        {
            
        }
    }
}
