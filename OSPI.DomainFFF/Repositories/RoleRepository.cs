using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class RoleRepository : Repository<RoleEntity>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
