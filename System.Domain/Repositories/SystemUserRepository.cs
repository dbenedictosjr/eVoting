using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SystemUserRepository : Repository<SystemUserEntity>, ISystemUserRepository
    {
        public SystemUserRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
