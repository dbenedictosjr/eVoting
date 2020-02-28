using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SystemUserAccessRepository : Repository<SystemUserAccessEntity>, ISystemUserAccessRepository
    {
        public SystemUserAccessRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
