using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SystemUserRepository : Repository<SystemUserEntity>, ISystemUserRepository
    {
        public SystemUserRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
