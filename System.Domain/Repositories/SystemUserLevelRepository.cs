using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class SystemUserLevelRepository : Repository<SystemUserLevelEntity>, ISystemUserLevelRepository
    {
        public SystemUserLevelRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
