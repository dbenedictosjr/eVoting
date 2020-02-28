using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class RoleRepository : Repository<RoleEntity>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}
